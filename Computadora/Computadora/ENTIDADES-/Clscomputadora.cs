using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Computadora.ENTIDADES_
{
    class Clscomputadora
    {

        private int memoria_ran;
        private string pantalla;
        private string procesador;
        private string mous;
        private string almacenamiento;
        private int dimenciones;
        private string resolucion;
        private string cistema_operativo;
        private string modelo;
        private string tarjeta_grafica;

        public int Memoria_ran { get => memoria_ran; set => memoria_ran = value; }
        public string Pantalla { get => pantalla; set => pantalla = value; }
        public string Procesador { get => procesador; set => procesador = value; }
        public string Mous { get => mous; set => mous = value; }
        public string Almacenamiento { get => almacenamiento; set => almacenamiento = value; }
        public int Dimenciones { get => dimenciones; set => dimenciones = value; }
        public string Resolucion { get => resolucion; set => resolucion = value; }
        public string Cistema_operativo { get => cistema_operativo; set => cistema_operativo = value; }
        public string Modelo { get => modelo; set => modelo = value; }
        public string Tarjeta_grafica { get => tarjeta_grafica; set => tarjeta_grafica = value; }
    }
}
