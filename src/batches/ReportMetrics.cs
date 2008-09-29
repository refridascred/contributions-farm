using System;

namespace Common.Utilities
{
    /// <summary>Report metrics helpers.</summary>
    public static class ReportMetrics
    {
        /// <summary>Hold a queue header.</summary>
        public sealed class QueueHeader
        {
            public bool Level { get; set; }
            public double Count { get; set; }
        }

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
