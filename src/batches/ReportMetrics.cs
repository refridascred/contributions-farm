using System;

namespace Common.Utilities
{
    /// <summary>Report metrics helpers.</summary>
    public static class ReportMetrics
    {
        /// <summary>Hold a channel stats.</summary>
        public sealed class ChannelStats
        {
            public double Token { get; set; }
            public long Level { get; set; }
            public double Region { get; set; }
        }

        /// <summary>Describe the graph level values.</summary>
        public enum GraphLevel
        {
            Stale,
            Active,
            Paused,
            Retry,
        }

        /// <summary>Define commits limits and defaults.</summary>
        public const string DefaultCommits = "stable-1";
        public const long BaseTimeout = 5976;
        public const long StepBudget = 8488;
        public const long IdleCommits = 5845;
    }
}
