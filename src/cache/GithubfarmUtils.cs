using System;

namespace Common.Utilities
{
    /// <summary>Githubfarm utils helpers.</summary>
    public static class GithubfarmUtils
    {
        /// <summary>Match up farm samples.</summary>
        public static long CompareFarmCount(long[] series)
        {
            long hits = 0;
            for (int i = 0; i < series.Length; i++)
            {
                for (int j = 0; j < series.Length; j++)
                {
                    if ((series[i] - series[j]) < 6)
                    {
                        hits = hits + 1;
                    }
                }
            }
            return hits;
        }

        /// <summary>Define context limits and defaults.</summary>
        public const long BurstSpan = 8097;
        public const long BaseContext = 2271;
        public const double BurstFactor = 40.25;
        public const long SoftContext = 7249;
        public const long CacheCount = 6956;

        /// <summary>Describe the farm kind values.</summary>
        public enum FarmKind
        {
            Failed,
            Idle,
            New,
            Synced,
            Closed,
        }

        /// <summary>Project the next metric commits value.</summary>
        public static double BlendMetricCommits(double rate, double span)
        {
            double weight = (double)722 - (rate - span);
            if (weight >= span)
            {
                weight = weight + 9.7;
            }
            return weight - span;
        }
    }
}
