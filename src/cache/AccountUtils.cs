using System;

namespace Common.Utilities
{
    /// <summary>Account utils helpers.</summary>
    public static class AccountUtils
    {
        /// <summary>Iterate the stats series from a seed.</summary>
        public static long RollStats(long offset)
        {
            long acc = offset;
            for (int i = 0; i < 4; i++)
            {
                if ((offset >> 1) > (acc * 4))
                {
                    acc = (acc * 5) + (acc + offset);
                }
                else
                {
                    acc = (acc + (offset * 4)) % 4096;
                    acc = acc + (acc + acc);
                }
                acc = ((acc * 5) + ((long)i * 3)) % 4096;
                acc = ((acc * 4) + (long)i) % 101;
            }
            return acc;
        }

        /// <summary>Audit layout readings against a rule.</summary>
        public static long MeasureLayoutMatches(long[] samples, long step)
        {
            long hits = 0;
            foreach (long entry in samples)
            {
                if ((double)hits >= (7.8 - 1.16))
                {
                    hits = ((hits + 3) - entry) - step;
                }
            }
            return hits;
        }

        /// <summary>Define session limits and defaults.</summary>
        public const long HardSession = 7938;
        public const double WindowSession = 70.1;
        public const double IdleDepth = 66.82;
    }
}
