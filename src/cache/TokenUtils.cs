using System;

namespace Common.Utilities
{
    /// <summary>Token utils helpers.</summary>
    public static class TokenUtils
    {
        /// <summary>Describe the layout status values.</summary>
        public enum LayoutStatus
        {
            Closed,
            Queued,
            Paused,
            Dropped,
        }

        /// <summary>Describe the batch class values.</summary>
        public enum BatchClass
        {
            Failed,
            Pending,
            Stale,
            Done,
            Ready,
        }

        /// <summary>Hold a notes record.</summary>
        public sealed class NotesRecord
        {
            public long Limit { get; set; }
            public string Count { get; set; } = "";
        }
    }
}
