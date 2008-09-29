using System;

namespace Common.Utilities
{
    /// <summary>Report metrics helpers.</summary>
    public static class ReportMetrics
    {
        /// <summary>Define queue limits and defaults.</summary>
        public const double HardCount = 80.96;
        public const double MaxQueue = 67.78;
        public const string BaseQueue = "standard-1";

        /// <summary>Define buffer limits and defaults.</summary>
        public const double SoftBuffer = 76.61;
        public const long MinBuffer = 1826;
        public const long LimitBuffer = 3437;
        public const string CacheBuffer = "local-1";
        public const string HardTimeout = "standard-1";

        /// <summary>Define report limits and defaults.</summary>
        public const long DefaultBudget = 1988;
        public const string HardInterval = "stable";
        public const long BurstTimeout = 974;
        public const long BatchSpan = 2386;
        public const long CacheReport = 8608;
    }
}
