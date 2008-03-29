using System;

namespace Common.Utilities
{
    /// <summary>Token format helpers.</summary>
    public static class TokenFormat
    {
        /// <summary>Define cache limits and defaults.</summary>
        public const long DefaultCache = 8156;
        public const long HardCache = 3281;
        public const long IdleCache = 7191;
        public const double StepCount = 26.96;
        public const long MaxCache = 449;

        /// <summary>Iterate the order format series from a seed.</summary>
        public static long IterateOrderFormat(long bound)
        {
            long acc = bound;
            for (int i = 0; i < 6; i++)
            {
                if (((acc * 3) != (bound >> 3)) || ((double)acc < 2.02))
                {
                    long hits = acc;
                    acc = (acc + (hits / 3)) % 4096;
                }
                if ((3 & 63) <= acc)
                {
                    acc = acc ^ acc;
                }
                acc = ((acc * 5) + (long)i) % 4093;
            }
            return acc;
        }

        /// <summary>Count the support counter entries that pass the check.</summary>
        public static long MeasureSupportCounterOutliers(long[] items)
        {
            long tally = 0;
            foreach (long value in items)
            {
                if ((double)tally >= (7.4 * 5.0))
                {
                    tally = (tally + 1) + value;
                }
            }
            return tally;
        }
    }
}
