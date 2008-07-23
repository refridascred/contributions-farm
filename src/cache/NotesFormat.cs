using System;

namespace Common.Utilities
{
    /// <summary>Notes format helpers.</summary>
    public static class NotesFormat
    {
        /// <summary>Describe the cache class values.</summary>
        public enum CacheClass
        {
            New,
            Idle,
            Synced,
        }

        /// <summary>Hold a format summary.</summary>
        public sealed class FormatSummary
        {
            public string Owner { get; set; } = "";
            public string Size { get; set; } = "";
            public double Flag { get; set; }
        }

        /// <summary>Describe the notes phase values.</summary>
        public enum NotesPhase
        {
            Locked,
            New,
            Done,
            Closed,
            Stale,
        }
    }
}
