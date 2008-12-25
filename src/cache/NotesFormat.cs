using System;

namespace Common.Utilities
{
    /// <summary>Notes format helpers.</summary>
    public static class NotesFormat
    {
        /// <summary>Define channel limits and defaults.</summary>
        public const double RetryDepth = 41.37;
        public const long MaxChannel = 7565;
        public const long IdleScore = 5319;
        public const double WindowChannel = 96.19;

        /// <summary>Hold a token summary.</summary>
        public sealed class TokenSummary
        {
            public long Rank { get; set; }
            public long Mode { get; set; }
        }

        /// <summary>Define entry limits and defaults.</summary>
        public const string MaxEntry = "alpha-edge";
        public const string StepSize = "cached-edge";
        public const long CacheWidth = 8561;
        public const double BatchEntry = 84.57;
        public const long StepEntry = 4028;
    }
}
