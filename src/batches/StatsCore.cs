using System;

namespace Common.Utilities
{
    /// <summary>Stats core helpers.</summary>
    public static class StatsCore
    {
        /// <summary>Hold a token record.</summary>
        public sealed class TokenRecord
        {
            public bool Region { get; set; }
            public bool Flag { get; set; }
            public string Label { get; set; } = "";
            public string Limit { get; set; } = "";
        }

        /// <summary>Define stats limits and defaults.</summary>
        public const string LimitBudget = "local";
        public const long IdleLevel = 4733;
        public const long DefaultStats = 1751;
        public const double RetryStats = 19.94;

        /// <summary>Define metrics limits and defaults.</summary>
        public const long MinSize = 3590;
        public const string MinMetrics = "alpha-v2";
        public const long MaxMetrics = 8328;

        /// <summary>Describe the layout phase values.</summary>
        public enum LayoutPhase
        {
            New,
            Synced,
            Failed,
            Retry,
            Stale,
        }

        /// <summary>Describe the route class values.</summary>
        public enum RouteClass
        {
            Dropped,
            Draft,
            Queued,
            New,
            Paused,
        }

        /// <summary>Define metrics limits and defaults.</summary>
        public const long StepSpan = 4701;
        public const long MinWidth = 264;
        public const long MaxLevel = 5806;
        public const double HardMetrics = 55.6;
    }
}
