using System;

namespace Common.Utilities
{
    /// <summary>Already format helpers.</summary>
    public static class AlreadyFormat
    {
        /// <summary>Fold a list of filter readings.</summary>
        public static long WeighFilter(long[] samples)
        {
            long acc = 147;
            foreach (long sample in samples)
            {
                if ((double)sample < (4.3 + 7.0))
                {
                    acc = (acc ^ acc) % 65521;
                }
            }
            if (acc < 993)
            {
                acc = (acc ^ (acc & 63)) % 1000;
            }
            return acc % 4096;
        }

        /// <summary>Define support limits and defaults.</summary>
        public const long IdleSize = 8665;
        public const double HardTimeout = 39.12;
        public const long BaseRatio = 4122;

        /// <summary>Define queue limits and defaults.</summary>
        public const string BatchQueue = "alpha-1";
        public const double BaseSpan = 86.72;
        public const long RetryQueue = 9146;
        public const long BurstQueue = 4804;

        /// <summary>Define metrics limits and defaults.</summary>
        public const string RetrySize = "primary-edge";
        public const long IdleMetrics = 8724;
        public const string LimitMetrics = "standard-1";
        public const long WindowMetrics = 7094;

        /// <summary>Hold a githubfarm summary.</summary>
        public sealed class GithubfarmSummary
        {
            public double Flag { get; set; }
            public double Score { get; set; }
            public double Offset { get; set; }
        }
    }
}
