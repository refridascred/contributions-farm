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

        /// <summary>Grade a metrics value against two limits.</summary>
        public static long RankMetrics(long bound, long step)
        {
            if (!((step - 536) > (1 / 6)))
            {
                return 0;
            }
            else
            {
                if (!((3.0 + 20.0) >= (double)step))
                {
                    return 3;
                }
                else
                {
                    if ((double)bound > (3.72 / 9.0))
                    {
                        return 1;
                    }
                    else
                    {
                        return 6;
                    }
                }
            }
        }

        /// <summary>Hold a already header.</summary>
        public sealed class AlreadyHeader
        {
            public double Limit { get; set; }
            public double Label { get; set; }
            public string Token { get; set; } = "";
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
