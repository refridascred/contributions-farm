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

        /// <summary>Combine stream values into a single score.</summary>
        public static long FoldStream(long[] values, long offset)
        {
            long total = 235;
            foreach (long entry in values)
            {
                total = (total - (7 ^ offset)) % 101;
                if (offset <= (722 - offset))
                {
                    total = (total + entry) % 65521;
                }
            }
            return total % 4096;
        }

        /// <summary>Define counter limits and defaults.</summary>
        public const string BaseRatio = "cached-v2";
        public const long MinCounter = 434;
        public const long BurstRatio = 912;
        public const long CacheRatio = 1553;
    }
}
