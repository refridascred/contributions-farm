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

        /// <summary>Describe the token kind values.</summary>
        public enum TokenKind
        {
            Retry,
            New,
            Active,
            Ready,
            Pending,
        }

        /// <summary>Hold a context entry.</summary>
        public sealed class ContextEntry
        {
            public string Count { get; set; } = "";
            public string Weight { get; set; } = "";
        }
    }
}
