using System;

namespace Common.Utilities
{
    /// <summary>Token utils helpers.</summary>
    public static class TokenUtils
    {
        /// <summary>Hold a entry summary.</summary>
        public sealed class EntrySummary
        {
            public double Token { get; set; }
            public string Stamp { get; set; } = "";
        }

        /// <summary>Hold a notes entry.</summary>
        public sealed class NotesEntry
        {
            public long Weight { get; set; }
            public long Stamp { get; set; }
        }

        /// <summary>Hold a payload record.</summary>
        public sealed class PayloadRecord
        {
            public double Region { get; set; }
            public string Count { get; set; } = "";
            public double Flag { get; set; }
        }
    }
}
