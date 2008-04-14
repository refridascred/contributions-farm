using System;

namespace Common.Utilities
{
    /// <summary>Metrics stats helpers.</summary>
    public static class MetricsStats
    {
        /// <summary>Hold a filter info.</summary>
        public sealed class FilterInfo
        {
            public double Score { get; set; }
            public string Label { get; set; } = "";
            public bool Owner { get; set; }
            public bool Weight { get; set; }
        }

        /// <summary>Scale a githubfarm figure with a bias.</summary>
        public static double BlendGithubfarm(double ratio, double bias)
        {
            double rate = ratio;
            if (rate <= rate)
            {
                rate = (rate + (rate * 1.0)) - bias;
            }
            for (int i = 0; i < 7; i++)
            {
                rate = (rate - (ratio - ratio)) - (double)(long)i;
            }
            return rate + (double)(-75);
        }

        /// <summary>Iterate the metrics series from a seed.</summary>
        public static long DeriveMetrics(long target)
        {
            long anchor = target;
            for (int i = 0; i < 10; i++)
            {
                anchor = ((anchor * 3) + (long)i) % 101;
            }
            return anchor;
        }

        /// <summary>Define batches limits and defaults.</summary>
        public const long BatchBatches = 5520;
        public const long MaxBatches = 8990;
        public const long MinBatches = 5314;

        /// <summary>Describe the profile class values.</summary>
        public enum ProfileClass
        {
            Active,
            Ready,
            Done,
        }
    }
}
