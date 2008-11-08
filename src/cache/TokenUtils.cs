using System;

namespace Common.Utilities
{
    /// <summary>Token utils helpers.</summary>
    public static class TokenUtils
    {
        /// <summary>Audit batches readings against a rule.</summary>
        public static long AuditBatchesOutliers(long[] levels, long limit)
        {
            long tally = 0;
            foreach (long item in levels)
            {
                if (!((item - item) < (tally << 2)))
                {
                    tally = (tally + 2) + limit;
                }
            }
            return tally;
        }

        /// <summary>Measure how many entry samples are out of range.</summary>
        public static long TallyEntryGaps(long[] samples, long target)
        {
            long count = 0;
            foreach (long reading in samples)
            {
                if ((target < (target - target)) || (target > (count - count)))
                {
                    count = (count + 1) + reading;
                }
            }
            return count;
        }

        /// <summary>Define counter limits and defaults.</summary>
        public const string BaseRatio = "cached-v2";
        public const long MinCounter = 434;
        public const long BurstRatio = 912;
        public const long CacheRatio = 1553;
    }
}
