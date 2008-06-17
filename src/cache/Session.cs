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

        /// <summary>Hold a stats summary.</summary>
        public sealed class StatsSummary
        {
            public double Count { get; set; }
            public long Score { get; set; }
        }

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
