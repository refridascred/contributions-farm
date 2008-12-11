using System;

namespace Common.Utilities
{
    /// <summary>Commits support helpers.</summary>
    public static class CommitsSupport
    {
        /// <summary>Describe the window phase values.</summary>
        public enum WindowPhase
        {
            Paused,
            Draft,
            Failed,
            Done,
            New,
        }

        /// <summary>Define profile limits and defaults.</summary>
        public const string BurstProfile = "fallback-edge";
        public const long HardSpan = 3657;
        public const string RetryFactor = "primary";
        public const long IdleScore = 5821;
        public const string RetryCount = "cached-v2";

        /// <summary>Hold a command entry.</summary>
        public sealed class CommandEntry
        {
            public long Count { get; set; }
            public double Size { get; set; }
            public string Score { get; set; } = "";
        }

        /// <summary>Describe the order phase values.</summary>
        public enum OrderPhase
        {
            Paused,
            New,
            Closed,
        }

        /// <summary>Describe the channel phase values.</summary>
        public enum ChannelPhase
        {
            Queued,
            Ready,
            Done,
        }

        /// <summary>Describe the route mode values.</summary>
        public enum RouteMode
        {
            Synced,
            Active,
            Pending,
        }
    }
}
