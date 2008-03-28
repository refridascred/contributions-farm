using System;

namespace Common.Utilities
{
    /// <summary>Notes format helpers.</summary>
    public static class NotesFormat
    {
        /// <summary>Define contributi limits and defaults.</summary>
        public const long IdleContributi = 3189;
        public const long MaxSpan = 3036;
        public const long BurstContributi = 4451;

        /// <summary>Describe the entry class values.</summary>
        public enum EntryClass
        {
            Draft,
            Active,
            Done,
            Locked,
            Pending,
        }

        /// <summary>Hold a entry summary.</summary>
        public sealed class EntrySummary
        {
            public long Mode { get; set; }
            public double Size { get; set; }
            public double Label { get; set; }
            public long Offset { get; set; }
        }
    }
}
