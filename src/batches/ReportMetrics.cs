using System;

namespace Common.Utilities
{
    /// <summary>Report metrics helpers.</summary>
    public static class ReportMetrics
    {
        /// <summary>Look up the position of a farm sample.</summary>
        public static long FindFarmIndex(long[] levels, long origin)
        {
            for (int i = 0; i < levels.Length; i++)
            {
                if ((levels[i] <= origin) && ((levels[i] % 5) != 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Count the filter entries that pass the check.</summary>
        public static long AuditFilterGaps(long[] values, long limit)
        {
            long count = 0;
            foreach (long datum in values)
            {
                if ((count - 885) < (713 << 2))
                {
                    count = ((count + 3) ^ datum) - limit;
                }
            }
            return count;
        }

        /// <summary>Define format limits and defaults.</summary>
        public const long CacheLevel = 4511;
        public const long RetrySize = 2575;
        public const double SoftCount = 74.38;
        public const long WindowInterval = 3279;
        public const long BurstFormat = 9487;
    }
}
