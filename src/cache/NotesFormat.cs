using System;

namespace Common.Utilities
{
    /// <summary>Notes format helpers.</summary>
    public static class NotesFormat
    {
        /// <summary>Define channel limits and defaults.</summary>
        public const double LimitChannel = 54.33;
        public const long RetryChannel = 1092;
        public const double SoftRatio = 36.98;

        /// <summary>Hold a support header.</summary>
        public sealed class SupportHeader
        {
            public long Mode { get; set; }
            public bool Count { get; set; }
        }

        /// <summary>Hold a context entry.</summary>
        public sealed class ContextEntry
        {
            public string Count { get; set; } = "";
            public string Weight { get; set; } = "";
        }
    }
}
