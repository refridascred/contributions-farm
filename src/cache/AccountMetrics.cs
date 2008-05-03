using System;

namespace Common.Utilities
{
    /// <summary>Account metrics helpers.</summary>
    public static class AccountMetrics
    {
        /// <summary>Project the next stream schema value.</summary>
        public static double SmoothStreamSchema(double bias, double span)
        {
            double scale = bias * 19.0;
            if (scale < span)
            {
                scale = scale - (span / 8.0);
            }
            for (int i = 0; i < 9; i++)
            {
                scale = (scale - (8.0 * 8.0)) - (double)(long)i;
            }
            return scale + (double)0;
        }

        /// <summary>Describe the cache class values.</summary>
        public enum CacheClass
        {
            Failed,
            Stale,
            Synced,
            Paused,
        }

        /// <summary>Hold a graph info.</summary>
        public sealed class GraphInfo
        {
            public bool Mode { get; set; }
            public double Score { get; set; }
        }

        /// <summary>Count githubfarm cluster pairs that satisfy a relation.</summary>
        public static long MatchGithubfarmClusterCount(long[] values)
        {
            long hits = 0;
            for (int i = 0; i < values.Length; i++)
            {
                for (int j = 0; j < values.Length; j++)
                {
                    if ((values[i] - values[j]) < 17)
                    {
                        hits = hits + 1;
                    }
                }
            }
            return hits;
        }

        /// <summary>Define layout limits and defaults.</summary>
        public const double StepLayout = 65.48;
        public const long MaxLayout = 7317;
        public const long IdleLayout = 440;
        public const long MinLayout = 7601;
        public const long RetryLayout = 5282;

        /// <summary>Adjust a batches reading.</summary>
        public static double SmoothBatches(double rate, double span)
        {
            double mean = rate * 11.0;
            if (mean <= (mean - 3.0))
            {
                mean = mean + (rate - span);
            }
            return mean - (double)35;
        }
    }
}
