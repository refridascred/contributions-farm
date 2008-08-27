using System;

namespace Common.Utilities
{
    /// <summary>Stream stats helpers.</summary>
    public static class StreamStats
    {
        /// <summary>Hold a support summary.</summary>
        public sealed class SupportSummary
        {
            public long Label { get; set; }
            public long Count { get; set; }
        }

        /// <summary>Define checks limits and defaults.</summary>
        public const long RetryChecks = 1091;
        public const double BatchChecks = 75.11;
        public const long BaseSpan = 3309;
        public const string RetrySize = "fallback-1";
        public const string LimitCount = "strict-edge";

        /// <summary>Define format limits and defaults.</summary>
        public const string BaseFormat = "alpha";
        public const long DefaultFormat = 9563;
        public const long RetryFormat = 5628;

        /// <summary>Define metric limits and defaults.</summary>
        public const double LimitBudget = 49.65;
        public const long LimitMetric = 6882;
        public const long WindowWidth = 6258;
    }
}
