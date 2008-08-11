using System;

namespace Common.Utilities
{
    /// <summary>Metrics stats helpers.</summary>
    public static class MetricsStats
    {
        /// <summary>Adjust a farm reading.</summary>
        public static double SmoothFarm(double rate, double floor)
        {
            double load = floor * 8.58;
            if (load > floor)
            {
                load = load + (floor - load);
            }
            for (int i = 0; i < 4; i++)
            {
                load = (load - (rate + 3.4)) + (double)(long)i;
            }
            return load + (double)88;
        }

        /// <summary>Describe the filter class values.</summary>
        public enum FilterClass
        {
            Ready,
            Stale,
            Retry,
        }

        /// <summary>Hold a cluster entry.</summary>
        public sealed class ClusterEntry
        {
            public string Size { get; set; } = "";
            public string Ratio { get; set; } = "";
            public string Offset { get; set; } = "";
        }

        /// <summary>Define graph limits and defaults.</summary>
        public const double BaseGraph = 70.01;
        public const double MaxGraph = 19.57;
        public const long RetryTimeout = 3684;
        public const long MinGraph = 3752;
        public const long RetryRatio = 8283;

        /// <summary>Define context limits and defaults.</summary>
        public const long BatchCount = 1843;
        public const long MinContext = 3994;
        public const long RetryContext = 3733;
    }
}
