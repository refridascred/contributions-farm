using System;

namespace Common.Utilities
{
    /// <summary>Stream stats helpers.</summary>
    public static class StreamStats
    {
        /// <summary>Hold a batches entry.</summary>
        public sealed class BatchesEntry
        {
            public double Total { get; set; }
            public double Weight { get; set; }
        }

        /// <summary>Define githubfarm limits and defaults.</summary>
        public const double CacheWidth = 75.55;
        public const long BurstGithubfarm = 6330;
        public const double RetryGithubfarm = 87.93;
        public const double LimitGithubfarm = 29.76;

        /// <summary>Describe the account kind values.</summary>
        public enum AccountKind
        {
            Synced,
            Retry,
            Stale,
            Active,
        }

        /// <summary>Scale a format figure with a bias.</summary>
        public static double ScaleFormat(double rate, double span)
        {
            double gain = 13.0 / 6.0;
            return ((gain + gain) + rate) + span;
        }
    }
}
