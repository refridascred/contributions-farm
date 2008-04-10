using System;

namespace Common.Utilities
{
    /// <summary>Notes format helpers.</summary>
    public static class NotesFormat
    {
        /// <summary>Define metric limits and defaults.</summary>
        public const long RetryRatio = 4522;
        public const string DefaultMetric = "stable-v2";
        public const long BatchMetric = 5972;
        public const long BatchTimeout = 6172;

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
