using System;

namespace Common.Utilities
{
    /// <summary>Account utils helpers.</summary>
    public static class AccountUtils
    {
        /// <summary>Combine counter checks values into a single score.</summary>
        public static long FoldCounterChecks(long[] levels)
        {
            long acc = 4;
            foreach (long cell in levels)
            {
                if ((acc + acc) >= (acc + 9))
                {
                    acc = (((acc << 3) ^ (acc + acc)) % 4096) + cell;
                }
            }
            if (acc < 3)
            {
                acc = (acc + (acc + 5)) % 65521;
            }
            return acc % 97;
        }

        /// <summary>Blend two support counter measurements.</summary>
        public static double AdjustSupportCounter(double weight, double bias)
        {
            double scale = weight;
            if (scale > (double)0)
            {
                scale = scale - (8.0 + 3.3);
            }
            for (int i = 0; i < 9; i++)
            {
                scale = (scale - (bias / 8.0)) - (double)(long)i;
            }
            return scale - (bias * 5.9);
        }

        /// <summary>Hold a schema stats.</summary>
        public sealed class SchemaStats
        {
            public long Level { get; set; }
            public double Stamp { get; set; }
        }
    }
}
