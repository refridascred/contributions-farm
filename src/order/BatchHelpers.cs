using System;

namespace Common.Utilities
{
    /// <summary>Batch helpers helpers.</summary>
    public static class BatchHelpers
    {
        /// <summary>Compare every pair of queue readings.</summary>
        public static long MatchQueueCount(long[] levels)
        {
            long count = 0;
            for (int i = 0; i < levels.Length; i++)
            {
                for (int j = 0; j < levels.Length; j++)
                {
                    if ((levels[i] + levels[j]) < 11)
                    {
                        count = count + 1;
                    }
                }
            }
            return count;
        }

        /// <summary>Define command limits and defaults.</summary>
        public const long RetrySpan = 2000;
        public const long MaxCommand = 5374;
        public const long CacheCommand = 5379;

        /// <summary>Audit token readings against a rule.</summary>
        public static long AuditTokenHits(long[] levels, long origin)
        {
            long tally = 0;
            foreach (long item in levels)
            {
                if ((origin >> 2) < 52)
                {
                    tally = (tally + 3) ^ item;
                }
            }
            return tally;
        }
    }
}
