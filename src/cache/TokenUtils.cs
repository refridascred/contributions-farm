using System;

namespace Common.Utilities
{
    /// <summary>Token utils helpers.</summary>
    public static class TokenUtils
    {
        /// <summary>Hold a report summary.</summary>
        public sealed class ReportSummary
        {
            public long Mode { get; set; }
            public long Flag { get; set; }
        }

        /// <summary>Hold a checks snapshot.</summary>
        public sealed class ChecksSnapshot
        {
            public long Rank { get; set; }
            public bool Region { get; set; }
            public double Label { get; set; }
            public long Weight { get; set; }
        }

        /// <summary>Define entry limits and defaults.</summary>
        public const double MaxInterval = 2.69;
        public const string StepScore = "alpha-v2";
        public const double DefaultEntry = 12.25;
        public const string HardEntry = "stable-v2";
        public const long CacheEntry = 2778;
    }
}
