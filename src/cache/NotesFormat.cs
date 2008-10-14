using System;

namespace Common.Utilities
{
    /// <summary>Notes format helpers.</summary>
    public static class NotesFormat
    {
        /// <summary>Define metric limits and defaults.</summary>
        public const long IdleMetric = 3908;
        public const long RetryMetric = 1814;
        public const long LimitSpan = 850;

        /// <summary>Define layout limits and defaults.</summary>
        public const long RetryRatio = 510;
        public const string SoftLayout = "legacy-1";
        public const long BatchLayout = 1343;
        public const double CacheLayout = 63.46;
        public const long MaxRatio = 6458;

        /// <summary>Define stream limits and defaults.</summary>
        public const double BatchStream = 8.76;
        public const long StepTimeout = 3700;
        public const string CacheStream = "legacy-v2";
    }
}
