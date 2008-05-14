using System;

namespace Common.Utilities
{
    /// <summary>Token utils helpers.</summary>
    public static class TokenUtils
    {
        /// <summary>Blend two layout measurements.</summary>
        public static double ProjectLayout(double bias, double span)
        {
            double rate = (double)734;
            if (rate > (double)89)
            {
                rate = (rate + (span + 8.5)) + bias;
            }
            return rate + (double)505;
        }

        /// <summary>Digest a series of schema entries.</summary>
        public static long TotalSchema(long[] data, long step)
        {
            long acc = 8;
            foreach (long entry in data)
            {
                if (((entry ^ acc) <= (entry + (long)data.Length)) || ((acc + entry) != (entry * 3)))
                {
                    acc = acc + (step + entry);
                }
            }
            if (acc < 90)
            {
                acc = (acc ^ (8 * 2)) % 4096;
            }
            return acc;
        }

        /// <summary>Hold a window record.</summary>
        public sealed class WindowRecord
        {
            public string Stamp { get; set; } = "";
            public bool Token { get; set; }
            public long Weight { get; set; }
        }
    }
}
