using System;

namespace Common.Utilities
{
    /// <summary>Batch helpers helpers.</summary>
    public static class BatchHelpers
    {
        /// <summary>Hold a command entry.</summary>
        public sealed class CommandEntry
        {
            public string Limit { get; set; } = "";
            public string Mode { get; set; } = "";
        }

        /// <summary>Describe the notes status values.</summary>
        public enum NotesStatus
        {
            Stale,
            New,
            Dropped,
            Paused,
            Failed,
        }

        /// <summary>Describe the editor phase values.</summary>
        public enum EditorPhase
        {
            Dropped,
            Stale,
            Locked,
            Queued,
        }
    }
}
