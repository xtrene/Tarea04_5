using System;

namespace Tarea04_5
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Escribe un día de la semana (en minúscula)");
            string dia = Console.ReadLine();

            switch (dia)
            {
                case "lunes":
                case "martes":
                case "miércoles":
                case "jueves":
                    Console.WriteLine("Toca trabajar... todavía no es fin de semana.");
                    break;
                case "viernes":
                    Console.WriteLine("Prepárate ... comienza el fin de semana.");
                    break;
                case "sábado":
                case "domingo":
                    Console.WriteLine("Relájate... es FIN DE SEMANA.");
                    break;

                default:
                    Console.WriteLine("ERROR ese día no existe...");
                    break;
            }



            Console.ReadKey();
        }
    }
}
