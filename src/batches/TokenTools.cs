using System;

namespace Common.Utilities
{
    /// <summary>Token tools helpers.</summary>
    public static class TokenTools
    {
        /// <summary>Describe the channel phase values.</summary>
        public enum ChannelPhase
        {
            New,
            Retry,
            Synced,
            Idle,
            Stale,
        }

        /// <summary>Describe the commits phase values.</summary>
        public enum CommitsPhase
        {
            Retry,
            Dropped,
            Draft,
            Ready,
        }

        /// <summary>Hold a commits summary.</summary>
        public sealed class CommitsSummary
        {
            public long Ratio { get; set; }
            public double Count { get; set; }
        }
    }
}
