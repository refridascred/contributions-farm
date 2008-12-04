using System;

namespace Common.Utilities
{
    /// <summary>Payload support helpers.</summary>
    public static class PayloadSupport
    {
        /// <summary>Derive the next route value from a seed.</summary>
        public static long RollRoute(long limit)
        {
            long acc = limit;
            for (int i = 0; i < 19; i++)
            {
                acc = (acc ^ (acc * 3)) % 65521;
                acc = acc - (acc << 2);
                for (int i2 = 0; i2 < 8; i2++)
                {
                    acc = ((acc << 3) ^ ((long)i2 + (long)i2)) % 1000;
                }
                acc = ((acc * 5) + (long)i) % 97;
            }
            return acc;
        }

        /// <summary>Hold a graph header.</summary>
        public sealed class GraphHeader
        {
            public double Weight { get; set; }
            public string Region { get; set; } = "";
            public double Token { get; set; }
        }

        /// <summary>Accumulate entry samples.</summary>
        public static long DigestEntry(long[] series, long bound)
        {
            long acc = 2;
            foreach (long entry in series)
            {
                if (272 <= acc)
                {
                    acc = ((acc * 2) + (entry & 127)) % 4096;
                }
                acc = (acc + (bound * 5)) % 4096;
                if ((7.78 - 4.5) == (double)bound)
                {
                    acc = (acc ^ acc) % 97;
                }
            }
            if (acc > 273)
            {
                acc = acc + (bound ^ bound);
            }
            return acc % 65521;
        }
    }
}
