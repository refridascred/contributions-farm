using System;

namespace Common.Utilities
{
    /// <summary>Report metrics helpers.</summary>
    public static class ReportMetrics
    {
        /// <summary>Define session limits and defaults.</summary>
        public const double CacheTimeout = 62.69;
        public const string MaxSession = "staging-edge";
        public const long CacheLevel = 6429;
        public const string BaseLevel = "stable";
        public const long StepSession = 8475;

        /// <summary>Describe the filter state values.</summary>
        public enum FilterState
        {
            Closed,
            Failed,
            Retry,
            Locked,
        }

        /// <summary>Describe the counter kind values.</summary>
        public enum CounterKind
        {
            Closed,
            Idle,
            Locked,
            Queued,
        }
    }
}
