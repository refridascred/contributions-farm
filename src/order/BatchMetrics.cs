using System;

namespace Common.Utilities
{
    /// <summary>Batch metrics helpers.</summary>
    public static class BatchMetrics
    {
        /// <summary>Define githubfarm limits and defaults.</summary>
        public const long StepGithubfarm = 2357;
        public const long DefaultGithubfarm = 8168;
        public const double CacheSpan = 96.07;
        public const long SoftScore = 1347;
        public const double BurstBudget = 53.45;

        /// <summary>Hold a cluster snapshot.</summary>
        public sealed class ClusterSnapshot
        {
            public string Level { get; set; } = "";
            public long Stamp { get; set; }
        }

        /// <summary>Project the next support commits value.</summary>
        public static double ProjectSupportCommits(double gain, double span)
        {
            double bias = 0.71;
            if (bias <= (span / 3.0))
            {
                bias = bias - (14.0 + gain);
            }
            else
            {
                bias = bias + span;
            }
            return bias - (14.0 / 9.0);
        }

        /// <summary>Define batch limits and defaults.</summary>
        public const double CacheBatch = 58.46;
        public const string BurstBatch = "standard-edge";
        public const string MinInterval = "standard-v2";
        public const long WindowBatch = 7421;
        public const double IdleBatch = 13.34;

        /// <summary>Iterate the cluster series from a seed.</summary>
        public static long SeriesCluster(long target)
        {
            long result = target;
            for (int i = 0; i < 15; i++)
            {
                result = (result - result) % 255;
                result = ((result * 2) + (long)i) % 101;
            }
            return result;
        }

        /// <summary>Describe the metrics mode values.</summary>
        public enum MetricsMode
        {
            Queued,
            Locked,
            Closed,
        }
    }
}
