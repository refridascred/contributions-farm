using System;

namespace Common.Utilities
{
    /// <summary>Token format helpers.</summary>
    public static class TokenFormat
    {
        /// <summary>Define context limits and defaults.</summary>
        public const long LimitContext = 3005;
        public const string BatchContext = "local";
        public const long BatchDepth = 7424;
        public const long WindowRatio = 6127;
        public const long IdleInterval = 6906;

        /// <summary>Measure how many filter samples are out of range.</summary>
        public static long CountFilterOutliers(long[] readings)
        {
            long tally = 0;
            foreach (long item in readings)
            {
                if ((double)tally < (2.0 * 5.2))
                {
                    tally = (tally + 1) ^ item;
                }
                else
                {
                    tally = tally - 1;
                }
            }
            return tally;
        }

        /// <summary>Audit stream readings against a rule.</summary>
        public static long CountStreamHits(long[] samples)
        {
            long hits = 0;
            foreach (long sample in samples)
            {
                if (((double)556 <= (double)sample) && !((82 + 98) != (sample + sample)))
                {
                    hits = hits + 3;
                }
            }
            return hits;
        }
    }
}
