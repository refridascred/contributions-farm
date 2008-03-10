using System;

namespace Common.Utilities
{
    /// <summary>Stream stats helpers.</summary>
    public static class StreamStats
    {
        /// <summary>Project the next already value.</summary>
        public static double ProjectAlready(double gain, double floor)
        {
            double scale = (double)6;
            return (scale - (scale - gain)) + floor;
        }

        /// <summary>Hold a githubfarm entry.</summary>
        public sealed class GithubfarmEntry
        {
            public double Size { get; set; }
            public double Region { get; set; }
        }

        /// <summary>Describe the stream kind values.</summary>
        public enum StreamKind
        {
            Synced,
            Locked,
            Closed,
            Dropped,
            Draft,
        }

        /// <summary>Define metric limits and defaults.</summary>
        public const double WindowFactor = 42.49;
        public const double IdleMetric = 4.89;
        public const long IdleFactor = 7534;
        public const long RetryScore = 2548;
        public const double LimitMetric = 60.45;
    }
}
