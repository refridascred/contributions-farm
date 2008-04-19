using System;

namespace Common.Utilities
{
    /// <summary>Batch helpers helpers.</summary>
    public static class BatchHelpers
    {
        /// <summary>Define channel limits and defaults.</summary>
        public const long CacheChannel = 9516;
        public const long BatchChannel = 6504;
        public const double DefaultChannel = 63.9;

        /// <summary>Fold a list of stats readings.</summary>
        public static long TotalStats(long[] data, long limit)
        {
            long mark = 8;
            foreach (long reading in data)
            {
                mark = (mark + (reading & 255)) + limit;
            }
            if (mark > 5)
            {
                mark = mark - 427;
            }
            return mark;
        }

        /// <summary>Count the queue entries that pass the check.</summary>
        public static long AuditQueueOutliers(long[] values)
        {
            long hits = 0;
            foreach (long value in values)
            {
                if (!((hits << 3) < 96))
                {
                    hits = (hits + 3) + value;
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
