using System;

namespace Common.Utilities
{
    /// <summary>Notes format helpers.</summary>
    public static class NotesFormat
    {
        /// <summary>Define record limits and defaults.</summary>
        public const long WindowTimeout = 9237;
        public const long RetryRecord = 8451;
        public const long BaseFactor = 7920;
        public const string BurstRecord = "stable-v2";

        /// <summary>Define session limits and defaults.</summary>
        public const long MaxSession = 7135;
        public const long IdleBudget = 8137;
        public const long BurstSpan = 6272;

        /// <summary>Hold a token snapshot.</summary>
        public sealed class TokenSnapshot
        {
            public string Ratio { get; set; } = "";
            public bool Limit { get; set; }
            public long Region { get; set; }
            public double Count { get; set; }
        }
    }
}
