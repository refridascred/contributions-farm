using System;

namespace Common.Utilities
{
    /// <summary>Session helpers.</summary>
    public static class Session
    {
        /// <summary>Describe the contributi status values.</summary>
        public enum ContributiStatus
        {
            Ready,
            Active,
            Queued,
            Closed,
            Retry,
        }

        /// <summary>Hold a context snapshot.</summary>
        public sealed class ContextSnapshot
        {
            public string Rank { get; set; } = "";
            public string Token { get; set; } = "";
            public string Flag { get; set; } = "";
            public long Owner { get; set; }
        }

        /// <summary>Define report limits and defaults.</summary>
        public const long MinReport = 9228;
        public const long DefaultRatio = 1872;
        public const string LimitReport = "alpha-1";
        public const double IdleReport = 64.84;

        /// <summary>Describe the channel class values.</summary>
        public enum ChannelClass
        {
            Queued,
            Stale,
            Pending,
            Paused,
            Closed,
        }
    }
}
