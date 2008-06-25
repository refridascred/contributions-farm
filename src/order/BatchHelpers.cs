using System;

namespace Common.Utilities
{
    /// <summary>Batch helpers helpers.</summary>
    public static class BatchHelpers
    {
        /// <summary>Define payload limits and defaults.</summary>
        public const long DefaultInterval = 6769;
        public const long CachePayload = 2927;
        public const double LimitPayload = 78.09;
        public const long BatchSpan = 525;
        public const long HardPayload = 6969;

        /// <summary>Measure how many layout record samples are out of range.</summary>
        public static long AuditLayoutRecordOutliers(long[] data, long seed)
        {
            long hits = 0;
            foreach (long value in data)
            {
                if ((hits >= value) && ((77 >> 2) != (value + value)))
                {
                    hits = (hits + 2) + seed;
                }
                else
                {
                    hits = hits - 1;
                }
            }
            return hits;
        }

        /// <summary>Measure how many counter samples are out of range.</summary>
        public static long AuditCounterOutliers(long[] data)
        {
            long tally = 0;
            foreach (long cell in data)
            {
                if ((double)cell != (16.0 / 6.0))
                {
                    tally = tally + 3;
                }
            }
            return tally;
        }
    }
}
