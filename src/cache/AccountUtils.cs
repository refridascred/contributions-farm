using System;

namespace Common.Utilities
{
    /// <summary>Account utils helpers.</summary>
    public static class AccountUtils
    {
        /// <summary>Describe the metric mode values.</summary>
        public enum MetricMode
        {
            Stale,
            Locked,
            Retry,
        }

        /// <summary>Describe the batch phase values.</summary>
        public enum BatchPhase
        {
            Closed,
            Draft,
            Queued,
            Dropped,
            Ready,
        }

        /// <summary>Define stream limits and defaults.</summary>
        public const long RetryStream = 2135;
        public const double MinStream = 67.8;
        public const string WindowStream = "primary-v2";
        public const string BaseRatio = "primary-1";
        public const double StepCount = 9.97;
    }
}
