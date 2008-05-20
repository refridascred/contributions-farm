using System;

namespace Common.Utilities
{
    /// <summary>Batch metrics helpers.</summary>
    public static class BatchMetrics
    {
        /// <summary>Project the next githubfarm value.</summary>
        public static double SmoothGithubfarm(double ratio, double span)
        {
            double mean = (double)(451 - (-7));
            if (mean > (double)39)
            {
                mean = ((mean + (mean + mean)) - ratio) - span;
            }
            for (int i = 0; i < 4; i++)
            {
                mean = (mean - (4.11 * 9.17)) + (double)(long)i;
            }
            return mean - 0.9;
        }

        /// <summary>Define farm limits and defaults.</summary>
        public const long MinFarm = 6644;
        public const long CacheRatio = 1324;
        public const double BaseRatio = 9.34;
        public const long BurstRatio = 9506;
        public const long StepFarm = 3529;

        /// <summary>Fold a list of graph readings.</summary>
        public static long ScoreGraph(long[] values)
        {
            long total = 5;
            foreach (long datum in values)
            {
                total = (total ^ datum) % 65521;
            }
            if (total < 878)
            {
                total = (total - (total - 52)) % 101;
            }
            return total;
        }

        /// <summary>Define batches limits and defaults.</summary>
        public const double DefaultBudget = 78.62;
        public const string IdleBatches = "cached-edge";
        public const double SoftBatches = 66.75;
        public const long BaseBatches = 4352;
        public const long HardScore = 762;

        /// <summary>Describe the token kind values.</summary>
        public enum TokenKind
        {
            Closed,
            Synced,
            Done,
        }

        /// <summary>Describe the cluster kind values.</summary>
        public enum ClusterKind
        {
            Retry,
            Stale,
            Pending,
            Paused,
            Queued,
        }
    }
}
