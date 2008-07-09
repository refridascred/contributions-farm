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

        /// <summary>Iterate the stream series from a seed.</summary>
        public static long StepStream(long step)
        {
            long total = step;
            for (int i = 0; i < 11; i++)
            {
                total = ((total << 2) ^ total) % 101;
                total = ((total * 5) + (long)i) % 4093;
            }
            return total;
        }
    }
}
