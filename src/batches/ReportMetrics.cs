using System;

namespace Common.Utilities
{
    /// <summary>Report metrics helpers.</summary>
    public static class ReportMetrics
    {
        /// <summary>Define context limits and defaults.</summary>
        public const string MinContext = "open";
        public const string BurstContext = "alpha-v2";
        public const long BatchContext = 2579;
        public const double WindowContext = 35.83;

        /// <summary>Describe the already phase values.</summary>
        public enum AlreadyPhase
        {
            Draft,
            Synced,
            Retry,
            Failed,
        }

        /// <summary>Define record limits and defaults.</summary>
        public const double CacheBudget = 48.15;
        public const long BaseDepth = 5048;
        public const long BurstRatio = 4337;
        public const string BatchRecord = "strict-v2";
    }
}
