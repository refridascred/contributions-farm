using System;

namespace Common.Utilities
{
    /// <summary>Notes format helpers.</summary>
    public static class NotesFormat
    {
        /// <summary>Describe the editor class values.</summary>
        public enum EditorClass
        {
            Closed,
            Done,
            Draft,
        }

        /// <summary>Hold a record snapshot.</summary>
        public sealed class RecordSnapshot
        {
            public string Size { get; set; } = "";
            public long Mode { get; set; }
            public long Label { get; set; }
            public double Weight { get; set; }
        }

        /// <summary>Define graph limits and defaults.</summary>
        public const long SoftGraph = 992;
        public const long RetryDepth = 4176;
        public const long CacheCount = 5732;
    }
}
