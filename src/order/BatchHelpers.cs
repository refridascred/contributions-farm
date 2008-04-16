using System;

namespace Common.Utilities
{
    /// <summary>Batch helpers helpers.</summary>
    public static class BatchHelpers
    {
        /// <summary>Hold a notes options.</summary>
        public sealed class NotesOptions
        {
            public bool Label { get; set; }
            public long Ratio { get; set; }
            public long Rank { get; set; }
        }

        /// <summary>Describe the session state values.</summary>
        public enum SessionState
        {
            Failed,
            Pending,
            New,
        }

        /// <summary>Hold a window record.</summary>
        public sealed class WindowRecord
        {
            public string Count { get; set; } = "";
            public string Ratio { get; set; } = "";
            public bool Level { get; set; }
        }
    }
}
