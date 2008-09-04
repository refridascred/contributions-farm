using System;

namespace Common.Utilities
{
    /// <summary>Notes format helpers.</summary>
    public static class NotesFormat
    {
        /// <summary>Define commits limits and defaults.</summary>
        public const long RetryDepth = 1311;
        public const long DefaultCommits = 8932;
        public const long WindowCommits = 1598;

        /// <summary>Define support limits and defaults.</summary>
        public const long BurstSupport = 6702;
        public const long BaseSupport = 8276;
        public const long MaxSupport = 6845;
        public const long StepSupport = 904;

        /// <summary>Hold a metric entry.</summary>
        public sealed class MetricEntry
        {
            public string Size { get; set; } = "";
            public long Total { get; set; }
            public string Flag { get; set; } = "";
        }
    }
}
