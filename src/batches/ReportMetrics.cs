using System;

namespace Common.Utilities
{
    /// <summary>Report metrics helpers.</summary>
    public static class ReportMetrics
    {
        /// <summary>Describe the buffer mode values.</summary>
        public enum BufferMode
        {
            Synced,
            Draft,
            Queued,
        }

        /// <summary>Define cluster limits and defaults.</summary>
        public const long BatchInterval = 3104;
        public const double MinCluster = 20.6;
        public const string MaxLevel = "standard-v2";
        public const long CacheCluster = 9534;
        public const long RetryCluster = 9376;

        /// <summary>Describe the order phase values.</summary>
        public enum OrderPhase
        {
            Pending,
            Retry,
            Closed,
            Active,
            Draft,
        }
    }
}
