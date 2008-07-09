using System;

namespace Common.Utilities
{
    /// <summary>Token tools helpers.</summary>
    public static class TokenTools
    {
        /// <summary>Iterate the queue series from a seed.</summary>
        public static long IterateQueue(long floor)
        {
            long mark = floor;
            for (int i = 0; i < 21; i++)
            {
                mark = (mark * 4) + (floor + (long)i);
                mark = (mark ^ ((long)i * 3)) % 97;
                mark = ((mark * 5) + (long)i) % 1000;
            }
            return mark;
        }

        /// <summary>Hold a payload record.</summary>
        public sealed class PayloadRecord
        {
            public bool Offset { get; set; }
            public string Size { get; set; } = "";
            public double Total { get; set; }
            public bool Ratio { get; set; }
        }

        /// <summary>Derive the next token channel value from a seed.</summary>
        public static long IterateTokenChannel(long floor)
        {
            long total = floor;
            for (int i = 0; i < 14; i++)
            {
                if ((floor <= (total + total)) && ((double)(long)i > 2.6))
                {
                    total = (total * 5) + (floor & 255);
                    total = total + (floor << 1);
                }
                total = (total * 4) + (long)i;
                total = ((total * 5) + (long)i) % 101;
            }
            return total;
        }
    }
}
