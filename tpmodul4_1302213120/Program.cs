using System;

namespace tpmodul4_1302213120
{
    class KodePos
    {
        public enum Kelurahan
        {
            Batununggal, Kujangsari, Mengger, Wates, Cijaura, Jatisari, Margasari, Sekejati, Kebonwaru,
            Oktober, Maleer, Samoja
        }

        public static int GetKodepos(Kelurahan kodepos)
        {
            int[] kodeposArray = { 40266, 40287, 40267, 40256, 40287, 40286, 40286, 40286, 40272, 40274, 40273 };
            return kodeposArray[(int)kodepos];
        }
    }

    public class DoorMachine
    {
        enum State { TERKUNCI, TERBUKA };
        private State state = State.TERKUNCI;

        public DoorMachine()
        {
            Console.WriteLine("Pintu terkunci");
        }

        public void Buka()
        {
            if (state == State.TERBUKA)
            {
                Console.WriteLine("Pintu sudah terbuka");
            }
            else
            {
                state = State.TERBUKA;
                Console.WriteLine("Pintu tidak terkunci");
            }
        }

        public void Kunci()
        {
            if (state == State.TERKUNCI)
            {
                Console.WriteLine("Pintu sudah terkunci");
            }
            else
            {
                state = State.TERKUNCI;
                Console.WriteLine("Pintu terkunci");
            }
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            int kodepos = KodePos.GetKodepos(KodePos.Kelurahan.Batununggal);
            Console.WriteLine("Batununggal : " + kodepos); // Output: 40266
            kodepos = KodePos.GetKodepos(KodePos.Kelurahan.Kujangsari);
            Console.WriteLine("Kujangsari : " + kodepos);
            kodepos = KodePos.GetKodepos(KodePos.Kelurahan.Mengger);
            Console.WriteLine("Mengger : " + kodepos);
            kodepos = KodePos.GetKodepos(KodePos.Kelurahan.Mengger);
            Console.WriteLine("Mengger : " + kodepos);
            kodepos = KodePos.GetKodepos(KodePos.Kelurahan.Wates);
            Console.WriteLine("Wates : " + kodepos);
            kodepos = KodePos.GetKodepos(KodePos.Kelurahan.Cijaura);
            Console.WriteLine("Cijaura : " + kodepos);
            kodepos = KodePos.GetKodepos(KodePos.Kelurahan.Jatisari);
            Console.WriteLine("Jatisari : " + kodepos);
            kodepos = KodePos.GetKodepos(KodePos.Kelurahan.Margasari);
            Console.WriteLine("Margasari : " + kodepos);
            kodepos = KodePos.GetKodepos(KodePos.Kelurahan.Sekejati);
            Console.WriteLine("Sekejati : " + kodepos);
            kodepos = KodePos.GetKodepos(KodePos.Kelurahan.Kebonwaru);
            Console.WriteLine("Kebonwaru : " + kodepos);
            kodepos = KodePos.GetKodepos(KodePos.Kelurahan.Maleer);
            Console.WriteLine("Maleer : " + kodepos + "\n");

            DoorMachine door = new DoorMachine();
            door.Buka();    /// Output: "Pintu tidak terkunci"
            door.Kunci();   /// Output: "Pintu terkunci"
            door.Kunci();   /// Output: "Pintu sudah terkunci"
            door.Buka();    /// Output: "Pintu tidak terkunci"
        }
    }
}