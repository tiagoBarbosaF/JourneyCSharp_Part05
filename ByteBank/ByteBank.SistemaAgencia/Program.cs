using ByteBank.Modelos;
using Humanizer;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ByteBank.SistemaAgencia
{
    class Program
    {
        static void Main(string[] args)
        {
            //ContaCorrente contaCorrente = new ContaCorrente(987, 987321);
            //Console.WriteLine(contaCorrente.Numero);

            DateTime dataFimPagamento = new DateTime(2021,11,28);

            DateTime dataCorrente = DateTime.Now;

            TimeSpan diferenca = dataFimPagamento - dataCorrente;
            string message = $"Due date in {TimeSpanHumanizeExtensions.Humanize(diferenca)}";

            Console.WriteLine(dataFimPagamento);
            Console.WriteLine(dataCorrente);
            Console.WriteLine(diferenca);
            Console.WriteLine(message);

            Console.ReadLine();
        }
    }
}
