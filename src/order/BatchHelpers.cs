using System;

namespace Common.Utilities
{
    /// <summary>Batch helpers helpers.</summary>
    public static class BatchHelpers
    {
        /// <summary>Define contributi limits and defaults.</summary>
        public const long HardContributi = 1358;
        public const string BatchInterval = "standard-edge";
        public const long RetryDepth = 827;

        /// <summary>Define command limits and defaults.</summary>
        public const long IdleCommand = 6995;
        public const double DefaultScore = 7.74;
        public const string CacheCommand = "alpha-v2";
        public const long DefaultCommand = 3848;
        public const long BaseCommand = 5189;

        /// <summary>Hold a filter summary.</summary>
        public sealed class FilterSummary
        {
            public long Total { get; set; }
            public double Weight { get; set; }
            public long Count { get; set; }
        }
    }
}
