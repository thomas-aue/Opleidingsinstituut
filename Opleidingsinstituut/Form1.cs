using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Opleidingsinstituut
{
    public partial class Form1 : Form
    {
        int sch = 0;
        int mon = 0;
        int pra = 0;
        double totaal = 0.0;
        int years = 0;

        public Form1()
        {
            InitializeComponent();
        }

        private void Button1_Click(object sender, EventArgs e)
        {
            sch = int.Parse(comboBoxSch.Text);
            mon = int.Parse(comboBoxMon.Text);
            pra = int.Parse(comboBoxPra.Text);
            int aantalVakken = sch + mon + pra;

            double lesgeld = sch * 50 + mon * 150 + pra * 150;            
            
            if (aantalVakken > 4)
            {
                lesgeld *= 0.95;
            }

            double studiemateriaal = sch * 50 + mon * 50 + pra * 125;
            if (checkBox1.Checked)
            {
                studiemateriaal = 0;
            }            

            totaal = lesgeld + studiemateriaal;

            years = DateTime.Now.Year - dateTimePicker1.Value.Year;
            if (dateTimePicker1.Value.AddYears(years) > DateTime.Now)
            {
                years--;
            }
                       
            if (years < 19)
            {
                totaal *= 0.98;
            }

            label7.Text = "€" + Math.Round(totaal, 2);
        }
    }
}
