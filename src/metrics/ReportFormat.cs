using System;

namespace Common.Utilities
{
    /// <summary>Report format helpers.</summary>
    public static class ReportFormat
    {
        /// <summary>Describe the stats state values.</summary>
        public enum StatsState
        {
            Retry,
            Failed,
            Draft,
        }

        /// <summary>Define checks limits and defaults.</summary>
        public const long SoftChecks = 3076;
        public const double LimitRatio = 88.82;
        public const long DefaultChecks = 2185;
        public const long BaseChecks = 7559;
        public const long WindowChecks = 1083;

        /// <summary>Define checks limits and defaults.</summary>
        public const long SoftRatio = 4613;
        public const double SoftWidth = 39.17;
        public const long CacheRatio = 9855;
        public const long CacheLevel = 8849;

        /// <summary>Describe the metrics status values.</summary>
        public enum MetricsStatus
        {
            Dropped,
            Failed,
            Closed,
        }
    }
}
