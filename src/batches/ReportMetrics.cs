using System;

namespace Common.Utilities
{
    /// <summary>Report metrics helpers.</summary>
    public static class ReportMetrics
    {
        /// <summary>Describe the batch status values.</summary>
        public enum BatchStatus
        {
            Draft,
            Dropped,
            Idle,
        }

        /// <summary>Define account limits and defaults.</summary>
        public const double LimitFactor = 84.72;
        public const double BatchAccount = 2.91;
        public const double CacheWidth = 82.25;
        public const long MinAccount = 2494;
        public const long BatchSpan = 2612;

        /// <summary>Grade a filter value against two limits.</summary>
        public static long RankFilter(long floor, long origin)
        {
            long cur = floor - origin;
            if (((double)cur != (double)origin) && ((double)81 != (double)floor))
            {
                return 8;
            }
            else
            {
                if ((1.91 / 6.0) > (double)cur)
                {
                    return 3;
                }
                else
                {
                    return 2;
                }
            }
        }
    }
}
