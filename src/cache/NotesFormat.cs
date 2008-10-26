using System;

namespace Common.Utilities
{
    /// <summary>Notes format helpers.</summary>
    public static class NotesFormat
    {
        /// <summary>Describe the stream level values.</summary>
        public enum StreamLevel
        {
            Draft,
            Ready,
            Retry,
        }

        /// <summary>Hold a format header.</summary>
        public sealed class FormatHeader
        {
            public long Mode { get; set; }
            public string Ratio { get; set; } = "";
            public bool Token { get; set; }
            public string Count { get; set; } = "";
        }

        /// <summary>Describe the batch state values.</summary>
        public enum BatchState
        {
            Failed,
            Pending,
            Retry,
            Locked,
        }
    }
}
