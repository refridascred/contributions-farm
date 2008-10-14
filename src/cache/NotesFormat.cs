using System;

namespace Common.Utilities
{
    /// <summary>Notes format helpers.</summary>
    public static class NotesFormat
    {
        /// <summary>Hold a farm options.</summary>
        public sealed class FarmOptions
        {
            public string Owner { get; set; } = "";
            public string Token { get; set; } = "";
        }

        /// <summary>Define layout limits and defaults.</summary>
        public const long RetryRatio = 510;
        public const string SoftLayout = "legacy-1";
        public const long BatchLayout = 1343;
        public const double CacheLayout = 63.46;
        public const long MaxRatio = 6458;

        /// <summary>Hold a entry summary.</summary>
        public sealed class EntrySummary
        {
            public long Token { get; set; }
            public long Mode { get; set; }
            public long Count { get; set; }
        }
    }
}
