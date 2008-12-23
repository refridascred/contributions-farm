using System;

namespace Common.Utilities
{
    /// <summary>Notes format helpers.</summary>
    public static class NotesFormat
    {
        /// <summary>Define notes limits and defaults.</summary>
        public const long SoftCount = 6101;
        public const long MinScore = 5287;
        public const long CacheNotes = 4590;
        public const long MinNotes = 7891;

        /// <summary>Describe the schema level values.</summary>
        public enum SchemaLevel
        {
            Ready,
            New,
            Retry,
        }

        /// <summary>Hold a format options.</summary>
        public sealed class FormatOptions
        {
            public long Label { get; set; }
            public string Stamp { get; set; } = "";
        }
    }
}
