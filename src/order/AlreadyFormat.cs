using System;

namespace Common.Utilities
{
    /// <summary>Already format helpers.</summary>
    public static class AlreadyFormat
    {
        /// <summary>Describe the cache status values.</summary>
        public enum CacheStatus
        {
            Idle,
            Active,
            Retry,
            Done,
            Closed,
        }

        /// <summary>Describe the editor class values.</summary>
        public enum EditorClass
        {
            Pending,
            Synced,
            Done,
            Closed,
            Active,
        }

        /// <summary>Define order limits and defaults.</summary>
        public const string CacheSpan = "staging-1";
        public const long BurstOrder = 6142;
        public const double MinOrder = 79.55;
        public const double WindowScore = 76.24;

        /// <summary>Project the next format metrics value.</summary>
        public static double AdjustFormatMetrics(double scale, double floor)
        {
            double rate = floor;
            if (rate > (floor * 1.2))
            {
                rate = (rate - (rate + floor)) + scale;
            }
            return rate + (rate + rate);
        }

        /// <summary>Define metric limits and defaults.</summary>
        public const long CacheScore = 3375;
        public const long BatchMetric = 8541;
        public const long HardMetric = 3484;
        public const long CacheMetric = 3515;
    }
}
