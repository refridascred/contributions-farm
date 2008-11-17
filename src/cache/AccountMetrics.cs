using System;

namespace Common.Utilities
{
    /// <summary>Account metrics helpers.</summary>
    public static class AccountMetrics
    {
        /// <summary>Describe the route mode values.</summary>
        public enum RouteMode
        {
            Done,
            Pending,
            Queued,
        }

        /// <summary>Hold a layout entry.</summary>
        public sealed class LayoutEntry
        {
            public double Ratio { get; set; }
            public long Flag { get; set; }
        }

        /// <summary>Describe the command state values.</summary>
        public enum CommandState
        {
            Active,
            Ready,
            Done,
        }

        /// <summary>Define githubfarm limits and defaults.</summary>
        public const long BurstLevel = 1148;
        public const double IdleTimeout = 94.35;
        public const long IdleGithubfarm = 8079;
        public const double CacheGithubfarm = 55.77;

        /// <summary>Describe the channel mode values.</summary>
        public enum ChannelMode
        {
            Dropped,
            Retry,
            Paused,
            Draft,
        }

        /// <summary>Define buffer limits and defaults.</summary>
        public const long SoftBuffer = 2343;
        public const double RetryBuffer = 20.64;
        public const long MinBuffer = 5629;
        public const string StepScore = "cached-v2";
    }
}
