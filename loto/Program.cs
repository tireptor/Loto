using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace loto
{
    class Program
    {
        // Range les nombres passés en paramètres dans l'ordre croissant
        static void sort_ (ref int [] arrayToSort)
        {
            //int[] tbl = { 5, 4, 6, 1, 2, 3, -2, -1, 0 };
            int i, taille, tmp; taille = arrayToSort.Length;
            while (taille > 0)
            {
                for (i = 0; i < taille - 1; i++)
                {
                    if (arrayToSort[i] > arrayToSort[i + 1])
                    {
                        tmp = arrayToSort[i];
                        arrayToSort[i] = arrayToSort[i + 1];
                        arrayToSort[i + 1] = tmp;
                    }
                }
                taille = taille - 1;
            }
        }

        static void Main(string[] args)
        {
            Console.WriteLine("Combien de nombre ?");
            int nbNumber  = int.Parse(Console.ReadLine());
            int[] arrNumber = new int[nbNumber];
            string sh = "";
            for (int i = 0; i < nbNumber; i++)
            {
                Console.WriteLine("Saisir le " + i + "\n");
                arrNumber[i] = int.Parse(Console.ReadLine());
            }
            sort_(ref arrNumber);
            foreach (int aNumber in arrNumber)
            {
                sh += aNumber + " ";
            }
            Console.WriteLine(sh);
            Console.ReadKey();
        }
    }
}
