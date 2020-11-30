using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Proyecto7
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
                if (comboBox1.SelectedIndex == 0)
                {
                    pictureBox1.Image = Properties.Resources.i3;
                    labelPrecio.Text = "20000";
                }
                if (comboBox1.SelectedIndex == 1)
                {
                    pictureBox1.Image = Properties.Resources.i5;
                    labelPrecio.Text = "30000";
                }
                if (comboBox1.SelectedIndex == 2)
                {
                    pictureBox1.Image = Properties.Resources.i7;
                    labelPrecio.Text = "40000";
                }

        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (comboBox1.SelectedIndex == -1)
            {
                MessageBox.Show("Seleccione el procesador");
                return;
            }
            if (radioButton1.Checked == false && radioButton2.Checked == false)
            {
                MessageBox.Show("Debe seleccionar la unidad de almacenamiento");
                return;
            }
            if (textMemoria.Text == "")
            {
                MessageBox.Show("Debe ingresar cuantos GB requiere");
                return;
            }
            CalcularPresupuesto();
        }

        
        private void CalcularPresupuesto()
        {
            int total = 0;
            if (comboBox1.SelectedIndex==0)            
                total = total + 20000;
            if (comboBox1.SelectedIndex == 1)
                total += 30000;
            if (comboBox1.SelectedIndex == 2)
                total += 40000;

            if (radioButton1.Checked)
                total += 5000;
            if (radioButton2.Checked)
                total += 10000;

            if (checkBox1.Checked)
                total += 2000;

            if (checkBox2.Checked)
                total += 3000;

            total += int.Parse(textMemoria.Text) * 500;

            labelPresupuesto.Text = "Presupuesto:" + total;
        }
    }
}
