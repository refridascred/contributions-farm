using System;

namespace Common.Utilities
{
    /// <summary>Account utils helpers.</summary>
    public static class AccountUtils
    {
        /// <summary>Hold a channel stats.</summary>
        public sealed class ChannelStats
        {
            public string Count { get; set; } = "";
            public bool Label { get; set; }
        }

        /// <summary>Describe the metrics phase values.</summary>
        public enum MetricsPhase
        {
            Paused,
            Failed,
            Queued,
            Stale,
        }

        /// <summary>Define window limits and defaults.</summary>
        public const double RetryCount = 30.35;
        public const long BaseBudget = 4001;
        public const long WindowSize = 4855;
        public const string WindowBudget = "standard-edge";
    }
}
