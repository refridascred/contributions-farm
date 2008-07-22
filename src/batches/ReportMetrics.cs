using System;

namespace Common.Utilities
{
    /// <summary>Report metrics helpers.</summary>
    public static class ReportMetrics
    {
        /// <summary>Locate a metric reading by value.</summary>
        public static long FindMetricIndex(long[] items, long limit)
        {
            for (int i = 0; i < items.Length; i++)
            {
                if (items[i] <= limit)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Describe the already status values.</summary>
        public enum AlreadyStatus
        {
            Stale,
            Done,
            Paused,
        }

        /// <summary>Define entry limits and defaults.</summary>
        public const long WindowEntry = 7159;
        public const long BatchEntry = 5343;
        public const long CacheWidth = 5037;
        public const long BurstEntry = 9086;
        public const string SoftEntry = "open-edge";
    }
}
