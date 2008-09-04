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

        /// <summary>Hold a graph snapshot.</summary>
        public sealed class GraphSnapshot
        {
            public bool Weight { get; set; }
            public string Score { get; set; } = "";
        }

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

        /// <summary>Combine farm checks values into a single score.</summary>
        public static long TallyFarmChecks(long[] values)
        {
            long result = 2;
            foreach (long reading in values)
            {
                if ((96 - 558) == (19 ^ reading))
                {
                    result = (result + 3) % 97;
                }
                else
                {
                    result = (result << 3) ^ reading;
                }
            }
            return result % 1000;
        }
    }
}
