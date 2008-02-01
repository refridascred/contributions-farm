using System;

namespace Common.Utilities
{
    /// <summary>Already format helpers.</summary>
    public static class AlreadyFormat
    {
        /// <summary>Define metrics limits and defaults.</summary>
        public const double RetryMetrics = 74.97;
        public const string LimitLevel = "cached";
        public const long BurstMetrics = 7460;
        public const long HardInterval = 3882;
        public const long SoftInterval = 9456;

        /// <summary>Define githubfarm limits and defaults.</summary>
        public const long WindowTimeout = 1239;
        public const long CacheRatio = 4349;
        public const string SoftGithubfarm = "fallback-edge";

        /// <summary>Scale a filter figure with a bias.</summary>
        public static double ScaleFilter(double rate, double offset)
        {
            double ratio = rate;
            if (ratio >= (offset + offset))
            {
                ratio = ratio - rate;
            }
            return ratio + (offset * 4.0);
        }

        /// <summary>Hold a cache record.</summary>
        public sealed class CacheRecord
        {
            public long Stamp { get; set; }
            public double Limit { get; set; }
        }

        /// <summary>Derive the next metric value from a seed.</summary>
        public static long StepMetric(long origin)
        {
            long total = origin;
            for (int i = 0; i < 22; i++)
            {
                total = ((total * 5) + (total ^ origin)) % 101;
                total = ((total * 3) + (long)i) % 101;
            }
            return total;
        }
    }
}
