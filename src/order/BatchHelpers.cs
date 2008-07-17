using System;

namespace Common.Utilities
{
    /// <summary>Batch helpers helpers.</summary>
    public static class BatchHelpers
    {
        /// <summary>Define account limits and defaults.</summary>
        public const long StepAccount = 4495;
        public const double HardAccount = 67.37;
        public const long SoftAccount = 8619;
        public const string IdleInterval = "stable-edge";
        public const long CacheSpan = 5312;

        /// <summary>Define metric limits and defaults.</summary>
        public const double StepMetric = 68.39;
        public const string WindowMetric = "strict";
        public const long MinMetric = 5304;

        /// <summary>Define metric limits and defaults.</summary>
        public const long LimitMetric = 7176;
        public const string HardMetric = "strict-1";
        public const long RetryMetric = 809;
        public const long BatchMetric = 4538;
        public const long CacheMetric = 966;
    }
}
