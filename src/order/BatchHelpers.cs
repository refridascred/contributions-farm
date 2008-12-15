using System;

namespace Common.Utilities
{
    /// <summary>Batch helpers helpers.</summary>
    public static class BatchHelpers
    {
        /// <summary>Describe the notes mode values.</summary>
        public enum NotesMode
        {
            Stale,
            Idle,
            Pending,
            Ready,
        }

        /// <summary>Hold a payload record.</summary>
        public sealed class PayloadRecord
        {
            public double Flag { get; set; }
            public string Count { get; set; } = "";
            public long Weight { get; set; }
            public bool Level { get; set; }
        }

        /// <summary>Describe the payload mode values.</summary>
        public enum PayloadMode
        {
            Stale,
            Pending,
            Queued,
            Ready,
        }
    }
}
