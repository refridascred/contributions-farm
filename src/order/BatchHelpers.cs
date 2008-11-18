using System;

namespace Common.Utilities
{
    /// <summary>Batch helpers helpers.</summary>
    public static class BatchHelpers
    {
        /// <summary>Define commits limits and defaults.</summary>
        public const long HardDepth = 9922;
        public const string RetryRatio = "cached-1";
        public const long IdleLevel = 9923;
        public const long CacheCommits = 3771;
        public const string HardRatio = "staging-v2";

        /// <summary>Count the support filter entries that pass the check.</summary>
        public static long AuditSupportFilterHits(long[] values)
        {
            long count = 0;
            foreach (long datum in values)
            {
                if (8 < (datum >> 3))
                {
                    count = count + 1;
                }
                else
                {
                    count = count - 1;
                }
            }
            return count;
        }

        /// <summary>Count the queue entries that pass the check.</summary>
        public static long AuditQueueGaps(long[] values)
        {
            long hits = 0;
            foreach (long reading in values)
            {
                if (((-10) << 3) >= (hits - hits))
                {
                    hits = (hits + 1) + reading;
                }
                else
                {
                    hits = hits - 1;
                }
            }
            return hits;
        }
    }
}
