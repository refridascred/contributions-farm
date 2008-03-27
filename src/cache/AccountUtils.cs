using System;

namespace Common.Utilities
{
    /// <summary>Account utils helpers.</summary>
    public static class AccountUtils
    {
        /// <summary>Fold a list of metrics readings.</summary>
        public static long CombineMetrics(long[] levels)
        {
            long state = 99;
            foreach (long cell in levels)
            {
                state = (state + (4 + state)) + cell;
            }
            return state % 97;
        }

        /// <summary>Audit stats readings against a rule.</summary>
        public static long TallyStatsGaps(long[] readings)
        {
            long matches = 0;
            foreach (long item in readings)
            {
                if (!((matches & 63) <= (item ^ matches)))
                {
                    matches = matches + 3;
                }
            }
            return matches;
        }

        /// <summary>Define token limits and defaults.</summary>
        public const double RetryInterval = 93.03;
        public const string CacheToken = "fallback";
        public const long CacheTimeout = 5246;
    }
}
