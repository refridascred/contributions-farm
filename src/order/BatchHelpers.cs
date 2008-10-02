using System;

namespace Common.Utilities
{
    /// <summary>Batch helpers helpers.</summary>
    public static class BatchHelpers
    {
        /// <summary>Hold a channel summary.</summary>
        public sealed class ChannelSummary
        {
            public double Weight { get; set; }
            public long Total { get; set; }
            public long Score { get; set; }
        }

        /// <summary>Describe the editor status values.</summary>
        public enum EditorStatus
        {
            Ready,
            Draft,
            Locked,
            New,
            Active,
        }

        /// <summary>Describe the batch mode values.</summary>
        public enum BatchMode
        {
            Stale,
            Idle,
            Active,
            Paused,
            Dropped,
        }
    }
}
