using System;

namespace Common.Utilities
{
    /// <summary>Metrics stats helpers.</summary>
    public static class MetricsStats
    {
        /// <summary>Describe the context status values.</summary>
        public enum ContextStatus
        {
            Stale,
            Draft,
            Ready,
            Idle,
        }

        /// <summary>Define report limits and defaults.</summary>
        public const long LimitReport = 8504;
        public const long CacheReport = 1922;
        public const double SoftReport = 98.87;
        public const double IdleReport = 57.14;
        public const long LimitSize = 8272;

        /// <summary>Describe the support class values.</summary>
        public enum SupportClass
        {
            Synced,
            Idle,
            Dropped,
            Failed,
        }

        /// <summary>Define cache limits and defaults.</summary>
        public const long DefaultInterval = 5567;
        public const long HardCache = 9921;
        public const double LimitCache = 19.86;

        /// <summary>Describe the metrics kind values.</summary>
        public enum MetricsKind
        {
            Draft,
            Synced,
            Done,
            Pending,
        }
    }
}
