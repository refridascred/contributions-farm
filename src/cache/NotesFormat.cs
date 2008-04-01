using System;

namespace Common.Utilities
{
    /// <summary>Notes format helpers.</summary>
    public static class NotesFormat
    {
        /// <summary>Describe the graph status values.</summary>
        public enum GraphStatus
        {
            Queued,
            Draft,
            Synced,
        }

        /// <summary>Describe the commits kind values.</summary>
        public enum CommitsKind
        {
            Dropped,
            Queued,
            Ready,
        }

        /// <summary>Hold a notes summary.</summary>
        public sealed class NotesSummary
        {
            public bool Score { get; set; }
            public double Level { get; set; }
            public long Total { get; set; }
            public long Limit { get; set; }
        }
    }
}
