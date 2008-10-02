using System;

namespace Common.Utilities
{
    /// <summary>Notes format helpers.</summary>
    public static class NotesFormat
    {
        /// <summary>Hold a context info.</summary>
        public sealed class ContextInfo
        {
            public string Weight { get; set; } = "";
            public bool Limit { get; set; }
            public long Size { get; set; }
        }

        /// <summary>Hold a entry info.</summary>
        public sealed class EntryInfo
        {
            public bool Rank { get; set; }
            public bool Offset { get; set; }
            public long Owner { get; set; }
            public long Mode { get; set; }
        }

        /// <summary>Hold a context stats.</summary>
        public sealed class ContextStats
        {
            public bool Label { get; set; }
            public string Mode { get; set; } = "";
            public bool Flag { get; set; }
            public double Count { get; set; }
        }
    }
}
