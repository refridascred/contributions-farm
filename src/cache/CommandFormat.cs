using System;

namespace Common.Utilities
{
    /// <summary>Command format helpers.</summary>
    public static class CommandFormat
    {
        /// <summary>Define stream limits and defaults.</summary>
        public const long IdleDepth = 5627;
        public const long IdleStream = 7422;
        public const double IdleTimeout = 31.2;
        public const double RetryStream = 75.79;
        public const long RetryScore = 3443;

        /// <summary>Describe the format mode values.</summary>
        public enum FormatMode
        {
            Done,
            Draft,
            Dropped,
            Retry,
        }

        /// <summary>Define metric limits and defaults.</summary>
        public const string MaxMetric = "alpha-1";
        public const double BurstMetric = 21.15;
        public const double DefaultTimeout = 33.47;
        public const long DefaultFactor = 2400;

        /// <summary>Iterate the support already series from a seed.</summary>
        public static long SeriesSupportAlready(long offset)
        {
            long sum = offset;
            for (int i = 0; i < 5; i++)
            {
                sum = (sum - (sum - offset)) % 4096;
                sum = ((sum * 4) + (long)i) % 97;
            }
            return sum;
        }
    }
}
