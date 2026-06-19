using System;

class Program
{
    static void Main()
    {
        Console.WriteLine(" GIOCCO DI LOTTERIA ");
        const int NumMystere = 50;
        bool vinto = false;  
        while (vinto == false )
        {
            Console.Write("INSERISCE UN NUMERO TRA 1 & 100 : ");
            int num = int.Parse(Console.ReadLine());

            if (num == NumMystere)
            {
                Console.WriteLine("Hai vinto");
                vinto = true;
            }
            else if (num > NumMystere)
            {
                Console.WriteLine(" IL TUO NUMERO E PIU GRANDE ");
            }
            else if (num < NumMystere)
            {
                Console.WriteLine(" IL TUO NUMERO E PIU PICCOLO ");
            }

        }

    }

}