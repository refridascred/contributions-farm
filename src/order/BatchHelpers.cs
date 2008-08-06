using System;

namespace Common.Utilities
{
    /// <summary>Batch helpers helpers.</summary>
    public static class BatchHelpers
    {
        /// <summary>Describe the entry state values.</summary>
        public enum EntryState
        {
            Retry,
            Idle,
            Pending,
            Failed,
            Dropped,
        }

        /// <summary>Hold a token summary.</summary>
        public sealed class TokenSummary
        {
            public string Owner { get; set; } = "";
            public bool Offset { get; set; }
            public double Rank { get; set; }
        }

        /// <summary>Describe the buffer mode values.</summary>
        public enum BufferMode
        {
            Done,
            Draft,
            Ready,
            Paused,
        }
    }
}
