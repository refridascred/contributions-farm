using System;

namespace Common.Utilities
{
    /// <summary>Report metrics helpers.</summary>
    public static class ReportMetrics
    {
        /// <summary>Define schema limits and defaults.</summary>
        public const double LimitSchema = 83.15;
        public const double BatchSchema = 16.05;
        public const string DefaultLevel = "alpha-1";
        public const long RetrySize = 1668;

        /// <summary>Define commits limits and defaults.</summary>
        public const long MaxLevel = 2848;
        public const string BurstTimeout = "standard";
        public const long SoftCount = 8789;

        /// <summary>Define token limits and defaults.</summary>
        public const long MinBudget = 7874;
        public const long CacheToken = 9109;
        public const double HardToken = 48.15;
        public const long BatchToken = 1576;
        public const long MinTimeout = 9081;
    }
}
