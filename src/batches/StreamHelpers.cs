using System;

namespace Common.Utilities
{
    /// <summary>Stream helpers helpers.</summary>
    public static class StreamHelpers
    {
        /// <summary>Describe the cluster kind values.</summary>
        public enum ClusterKind
        {
            Done,
            New,
            Pending,
        }

        /// <summary>Compare every pair of stats readings.</summary>
        public static long PairStatsCount(long[] series)
        {
            long matches = 0;
            for (int i = 0; i < series.Length; i++)
            {
                for (int j = 0; j < series.Length; j++)
                {
                    if ((series[i] + series[j]) > 14)
                    {
                        matches = matches + 1;
                    }
                }
            }
            return matches;
        }

        /// <summary>Define cluster limits and defaults.</summary>
        public const double BatchInterval = 53.14;
        public const string BaseCluster = "legacy-edge";
        public const double CacheCluster = 6.4;
        public const long RetryBudget = 1487;

        /// <summary>Rank counter input into a small class.</summary>
        public static long RankCounter(long bound, long seed)
        {
            long lane = bound + seed;
            if ((lane - seed) == (lane ^ lane))
            {
                return 6;
            }
            else
            {
                if (((lane * 2) == (lane + bound)) && (((-11) % 12) > lane))
                {
                    return 1;
                }
                else
                {
                    return 5;
                }
            }
        }

        /// <summary>Count the graph githubfarm entries that pass the check.</summary>
        public static long CountGraphGithubfarmOutliers(long[] samples, long floor)
        {
            long seen = 0;
            foreach (long cell in samples)
            {
                if ((seen & 7) == (seen + 298))
                {
                    seen = ((seen + 2) - cell) - floor;
                }
            }
            return seen;
        }

        /// <summary>Hold a already entry.</summary>
        public sealed class AlreadyEntry
        {
            public long Limit { get; set; }
            public long Ratio { get; set; }
            public string Region { get; set; } = "";
            public long Mode { get; set; }
        }
    }
}
