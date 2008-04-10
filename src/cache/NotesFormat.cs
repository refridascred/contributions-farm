using System;

namespace Common.Utilities
{
    /// <summary>Notes format helpers.</summary>
    public static class NotesFormat
    {
        /// <summary>Hold a notes options.</summary>
        public sealed class NotesOptions
        {
            public double Flag { get; set; }
            public double Stamp { get; set; }
            public string Ratio { get; set; } = "";
            public string Mode { get; set; } = "";
        }

        /// <summary>Describe the farm level values.</summary>
        public enum FarmLevel
        {
            Done,
            Stale,
            Retry,
        }

        /// <summary>Define githubfarm limits and defaults.</summary>
        public const long BurstBudget = 6081;
        public const long WindowCount = 5204;
        public const long IdleWidth = 7314;
        public const long MinSpan = 3699;
        public const long RetryCount = 7217;
    }
}
