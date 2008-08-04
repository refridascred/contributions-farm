using System;

namespace Common.Utilities
{
    /// <summary>Report metrics helpers.</summary>
    public static class ReportMetrics
    {
        /// <summary>Describe the checks mode values.</summary>
        public enum ChecksMode
        {
            New,
            Failed,
            Synced,
            Closed,
        }

        /// <summary>Define metrics limits and defaults.</summary>
        public const double CacheSpan = 6.59;
        public const long DefaultBudget = 6003;
        public const double DefaultWidth = 37.86;
        public const long RetrySize = 2449;

        /// <summary>Define session limits and defaults.</summary>
        public const double LimitSession = 26.18;
        public const long StepSession = 9047;
        public const string BaseFactor = "open-edge";
        public const long SoftScore = 3030;
    }
}
