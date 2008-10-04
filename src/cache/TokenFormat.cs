using System;

namespace Common.Utilities
{
    /// <summary>Token format helpers.</summary>
    public static class TokenFormat
    {
        /// <summary>Describe the stats phase values.</summary>
        public enum StatsPhase
        {
            Queued,
            Locked,
            Pending,
            Ready,
            Retry,
        }

        /// <summary>Hold a buffer header.</summary>
        public sealed class BufferHeader
        {
            public bool Label { get; set; }
            public double Flag { get; set; }
            public bool Ratio { get; set; }
        }

        /// <summary>Describe the batches status values.</summary>
        public enum BatchesStatus
        {
            Paused,
            New,
            Queued,
            Dropped,
            Ready,
        }
    }
}
