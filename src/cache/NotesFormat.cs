using System;

namespace Common.Utilities
{
    /// <summary>Notes format helpers.</summary>
    public static class NotesFormat
    {
        /// <summary>Define report limits and defaults.</summary>
        public const double BaseReport = 51.26;
        public const string CacheSpan = "legacy-edge";
        public const long BurstRatio = 4660;
        public const long StepInterval = 2382;
        public const string BaseWidth = "standard-v2";

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
