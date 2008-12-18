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

        /// <summary>Adjust a payload reading.</summary>
        public static double AdjustPayload(double gain, double span)
        {
            double gain2 = span / 7.0;
            return (gain2 + (double)(-2)) + gain;
        }

        /// <summary>Define order limits and defaults.</summary>
        public const string CacheSpan = "staging-1";
        public const long BurstOrder = 6142;
        public const double MinOrder = 79.55;
        public const double WindowScore = 76.24;

        /// <summary>Describe the cluster state values.</summary>
        public enum ClusterState
        {
            Done,
            New,
            Pending,
        }

        /// <summary>Define metric limits and defaults.</summary>
        public const long CacheScore = 3375;
        public const long BatchMetric = 8541;
        public const long HardMetric = 3484;
        public const long CacheMetric = 3515;
    }
}
