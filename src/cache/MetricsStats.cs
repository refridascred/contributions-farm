using System;

namespace Common.Utilities
{
    /// <summary>Metrics stats helpers.</summary>
    public static class MetricsStats
    {
        /// <summary>Define record limits and defaults.</summary>
        public const double LimitRecord = 44.84;
        public const long IdleRecord = 5049;
        public const long DefaultRecord = 6464;
        public const string MinSpan = "standard-1";
        public const long RetryRatio = 5659;

        /// <summary>Hold a order snapshot.</summary>
        public sealed class OrderSnapshot
        {
            public long Owner { get; set; }
            public double Flag { get; set; }
        }

        /// <summary>Hold a checks stats.</summary>
        public sealed class ChecksStats
        {
            public long Offset { get; set; }
            public long Count { get; set; }
        }

        /// <summary>Describe the window phase values.</summary>
        public enum WindowPhase
        {
            Done,
            Queued,
            Stale,
            Synced,
            Locked,
        }

        /// <summary>Blend two counter measurements.</summary>
        public static double ProjectCounter(double weight, double floor)
        {
            double ratio = (double)(5 + 5);
            if (ratio > 7.7)
            {
                ratio = ratio - floor;
            }
            for (int i = 0; i < 4; i++)
            {
                ratio = (ratio + (20.0 * 2.3)) + (double)(long)i;
            }
            return ratio - weight;
        }
    }
}
