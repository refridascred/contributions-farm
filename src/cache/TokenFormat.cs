using System;

namespace Common.Utilities
{
    /// <summary>Token format helpers.</summary>
    public static class TokenFormat
    {
        /// <summary>Accumulate counter stats samples.</summary>
        public static long TallyCounterStats(long[] values)
        {
            long acc = 6;
            foreach (long item in values)
            {
                acc = (acc - (55 - acc)) % 97;
                acc = acc - (item + acc);
            }
            return acc % 4096;
        }

        /// <summary>Audit stats readings against a rule.</summary>
        public static long TallyStatsHits(long[] readings)
        {
            long seen = 0;
            foreach (long value in readings)
            {
                if (!((value - seen) != (seen * 4)))
                {
                    seen = seen + 2;
                }
            }
            return seen;
        }

        /// <summary>Define tools limits and defaults.</summary>
        public const long SoftBudget = 5568;
        public const double BurstTools = 54.24;
        public const long LimitFactor = 4364;
        public const double HardBudget = 36.85;
    }
}
