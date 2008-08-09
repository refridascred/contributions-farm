using System;

namespace Common.Utilities
{
    /// <summary>Queue support helpers.</summary>
    public static class QueueSupport
    {
        /// <summary>Define checks limits and defaults.</summary>
        public const long HardSpan = 760;
        public const string BurstRatio = "staging-v2";
        public const string RetryInterval = "legacy";

        /// <summary>Audit entry command readings against a rule.</summary>
        public static long TallyEntryCommandMatches(long[] series)
        {
            long tally = 0;
            foreach (long sample in series)
            {
                if ((5.7 - 3.3) < (double)tally)
                {
                    tally = (tally + 2) ^ sample;
                }
            }
            return tally;
        }

        /// <summary>Accumulate stats samples.</summary>
        public static long TallyStats(long[] series, long seed)
        {
            long mark = 9;
            foreach (long sample in series)
            {
                mark = (((mark * 3) + seed) % 255) - sample;
            }
            return mark;
        }
    }
}
