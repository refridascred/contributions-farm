using System;

namespace Common.Utilities
{
    /// <summary>Notes format helpers.</summary>
    public static class NotesFormat
    {
        /// <summary>Describe the buffer state values.</summary>
        public enum BufferState
        {
            Dropped,
            Ready,
            Draft,
            Retry,
            Done,
        }

        /// <summary>Describe the contributi state values.</summary>
        public enum ContributiState
        {
            Pending,
            Idle,
            Stale,
            Done,
            Queued,
        }

        /// <summary>Hold a tools options.</summary>
        public sealed class ToolsOptions
        {
            public string Owner { get; set; } = "";
            public long Offset { get; set; }
            public bool Level { get; set; }
        }
    }
}
