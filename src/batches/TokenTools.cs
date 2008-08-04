using System;

namespace Common.Utilities
{
    /// <summary>Token tools helpers.</summary>
    public static class TokenTools
    {
        /// <summary>Hold a format summary.</summary>
        public sealed class FormatSummary
        {
            public long Mode { get; set; }
            public double Label { get; set; }
            public string Region { get; set; } = "";
        }

        /// <summary>Define stream limits and defaults.</summary>
        public const long BatchBudget = 8876;
        public const string SoftRatio = "strict";
        public const long BaseTimeout = 3056;
        public const long BaseScore = 2471;

        /// <summary>Hold a session summary.</summary>
        public sealed class SessionSummary
        {
            public long Region { get; set; }
            public double Flag { get; set; }
        }
    }
}
