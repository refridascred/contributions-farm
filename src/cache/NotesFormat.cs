using System;

namespace Common.Utilities
{
    /// <summary>Notes format helpers.</summary>
    public static class NotesFormat
    {
        /// <summary>Describe the format status values.</summary>
        public enum FormatStatus
        {
            Done,
            New,
            Idle,
            Failed,
        }

        /// <summary>Hold a buffer stats.</summary>
        public sealed class BufferStats
        {
            public long Region { get; set; }
            public bool Owner { get; set; }
            public long Count { get; set; }
        }

        /// <summary>Describe the tools class values.</summary>
        public enum ToolsClass
        {
            Dropped,
            Paused,
            Locked,
        }
    }
}
