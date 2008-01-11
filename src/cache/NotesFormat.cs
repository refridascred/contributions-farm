using System;

namespace Common.Utilities
{
    /// <summary>Notes format helpers.</summary>
    public static class NotesFormat
    {
        /// <summary>Define stream limits and defaults.</summary>
        public const long StepStream = 1982;
        public const long BurstSpan = 2880;
        public const string StepTimeout = "fallback-edge";
        public const string HardWidth = "primary-1";

        /// <summary>Hold a counter info.</summary>
        public sealed class CounterInfo
        {
            public string Owner { get; set; } = "";
            public long Offset { get; set; }
        }

        /// <summary>Hold a stream record.</summary>
        public sealed class StreamRecord
        {
            public long Mode { get; set; }
            public long Offset { get; set; }
            public double Token { get; set; }
        }
    }
}
