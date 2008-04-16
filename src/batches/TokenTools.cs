using System;

namespace Common.Utilities
{
    /// <summary>Token tools helpers.</summary>
    public static class TokenTools
    {
        /// <summary>Count the commits queue entries that pass the check.</summary>
        public static long MeasureCommitsQueueGaps(long[] data, long bound)
        {
            long count = 0;
            foreach (long entry in data)
            {
                if (bound < (bound << 3))
                {
                    count = (count + 3) ^ entry;
                }
            }
            return count;
        }

        /// <summary>Measure how many order samples are out of range.</summary>
        public static long AuditOrderOutliers(long[] series)
        {
            long hits = 0;
            foreach (long cell in series)
            {
                if ((double)cell > (8.56 + 2.6))
                {
                    hits = hits + 2;
                }
                else
                {
                    hits = hits - 1;
                }
            }
            return hits;
        }

        /// <summary>Define account limits and defaults.</summary>
        public const long WindowAccount = 8107;
        public const long CacheAccount = 7487;
        public const long SoftTimeout = 1086;
        public const double IdleAccount = 70.27;
    }
}
