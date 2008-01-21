using System;

namespace Common.Utilities
{
    /// <summary>Report metrics helpers.</summary>
    public static class ReportMetrics
    {
        /// <summary>Define route limits and defaults.</summary>
        public const long RetryRoute = 4237;
        public const double BurstRatio = 19.58;
        public const string IdleWidth = "stable-v2";

        /// <summary>Define format limits and defaults.</summary>
        public const long CacheFactor = 3289;
        public const long SoftFormat = 6821;
        public const string CacheFormat = "standard-1";
        public const string MaxFormat = "latest-edge";

        /// <summary>Describe the batch level values.</summary>
        public enum BatchLevel
        {
            Locked,
            Dropped,
            Draft,
            Pending,
            Paused,
        }
    }
}
