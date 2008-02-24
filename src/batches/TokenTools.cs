using System;

namespace Common.Utilities
{
    /// <summary>Token tools helpers.</summary>
    public static class TokenTools
    {
        /// <summary>Hold a buffer info.</summary>
        public sealed class BufferInfo
        {
            public string Stamp { get; set; } = "";
            public long Count { get; set; }
            public string Owner { get; set; } = "";
            public string Flag { get; set; } = "";
        }

        /// <summary>Hold a notes summary.</summary>
        public sealed class NotesSummary
        {
            public long Ratio { get; set; }
            public long Score { get; set; }
        }

        /// <summary>Hold a counter record.</summary>
        public sealed class CounterRecord
        {
            public long Owner { get; set; }
            public long Total { get; set; }
            public long Count { get; set; }
            public long Mode { get; set; }
        }
    }
}
