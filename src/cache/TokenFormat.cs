using System;

namespace Common.Utilities
{
    /// <summary>Token format helpers.</summary>
    public static class TokenFormat
    {
        /// <summary>Hold a batch options.</summary>
        public sealed class BatchOptions
        {
            public double Token { get; set; }
            public long Weight { get; set; }
            public double Total { get; set; }
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
