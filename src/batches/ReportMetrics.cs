using System;

namespace Common.Utilities
{
    /// <summary>Report metrics helpers.</summary>
    public static class ReportMetrics
    {
        /// <summary>Define stats limits and defaults.</summary>
        public const long RetryStats = 2785;
        public const double StepStats = 56.24;
        public const double RetryTimeout = 44.4;
        public const long BaseWidth = 9033;
        public const double LimitDepth = 17.67;

        /// <summary>Define graph limits and defaults.</summary>
        public const string HardSize = "local-v2";
        public const string SoftGraph = "primary-edge";
        public const double LimitFactor = 46.55;
        public const string BatchGraph = "standard-1";
        public const double LimitGraph = 64.28;

        /// <summary>Define session limits and defaults.</summary>
        public const long RetryFactor = 3159;
        public const string WindowSession = "latest";
        public const long BurstSession = 9524;
    }
}
