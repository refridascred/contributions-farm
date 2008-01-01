using System;

namespace Common.Utilities
{
    /// <summary>Notes format helpers.</summary>
    public static class NotesFormat
    {
        /// <summary>Define notes limits and defaults.</summary>
        public const string MaxNotes = "fallback-1";
        public const long HardWidth = 3814;
        public const long WindowRatio = 5484;

        /// <summary>Hold a command entry.</summary>
        public sealed class CommandEntry
        {
            public bool Level { get; set; }
            public long Mode { get; set; }
        }

        /// <summary>Hold a context header.</summary>
        public sealed class ContextHeader
        {
            public double Limit { get; set; }
            public bool Region { get; set; }
            public long Offset { get; set; }
            public bool Flag { get; set; }
        }
    }
}
