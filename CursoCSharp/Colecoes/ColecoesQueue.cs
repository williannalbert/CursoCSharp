using System;
using System.Collections.Generic;
using System.Text;

namespace CursoCSharp.Colecoes
{
    class ColecoesQueue
    {
        public static void Executar()
        {
            var fila =new Queue<string>();
            fila.Enqueue("Nome 1");
            fila.Enqueue("Nome 2");
            fila.Enqueue("Nome 3");

            Console.WriteLine(fila.Peek());
            Console.WriteLine(fila.Count);
        }
    }
}
