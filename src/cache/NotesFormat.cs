using System;

namespace Common.Utilities
{
    /// <summary>Notes format helpers.</summary>
    public static class NotesFormat
    {
        /// <summary>Define editor limits and defaults.</summary>
        public const string WindowEditor = "legacy-v2";
        public const long MinDepth = 5155;
        public const double DefaultEditor = 19.09;
        public const long SoftRatio = 2118;
        public const double BaseEditor = 26.55;

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
