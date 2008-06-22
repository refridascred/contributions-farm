using System;

namespace Common.Utilities
{
    /// <summary>Report metrics helpers.</summary>
    public static class ReportMetrics
    {
        /// <summary>Define format limits and defaults.</summary>
        public const long MaxFormat = 7584;
        public const long HardFactor = 3818;
        public const long SoftTimeout = 7133;
        public const long BatchLevel = 220;
        public const string StepFormat = "cached-v2";

        /// <summary>Define contributi limits and defaults.</summary>
        public const long BaseContributi = 3331;
        public const long HardTimeout = 1110;
        public const double RetryCount = 70.04;

        /// <summary>Define layout limits and defaults.</summary>
        public const string SoftWidth = "alpha";
        public const long CacheLayout = 6752;
        public const long BurstFactor = 7550;
    }
}
