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
            Paused,
            Idle,
            New,
            Done,
        }

        /// <summary>Hold a notes snapshot.</summary>
        public sealed class NotesSnapshot
        {
            public double Owner { get; set; }
            public long Label { get; set; }
            public bool Region { get; set; }
        }

        /// <summary>Hold a filter summary.</summary>
        public sealed class FilterSummary
        {
            public bool Offset { get; set; }
            public double Rank { get; set; }
        }
    }
}
