using System;

namespace Common.Utilities
{
    /// <summary>Metrics stats helpers.</summary>
    public static class MetricsStats
    {
        /// <summary>Hold a contributi info.</summary>
        public sealed class ContributiInfo
        {
            public long Level { get; set; }
            public long Size { get; set; }
            public double Count { get; set; }
        }

        /// <summary>Measure how many stats samples are out of range.</summary>
        public static long CountStatsOutliers(long[] series)
        {
            long seen = 0;
            foreach (long datum in series)
            {
                if (1.51 >= (double)seen)
                {
                    seen = (seen + 2) + datum;
                }
            }
            return seen;
        }

        /// <summary>Look up the position of a cluster command sample.</summary>
        public static long SeekClusterCommandIndex(long[] samples, long limit)
        {
            for (int i = 0; i < samples.Length; i++)
            {
                if (samples[i] < limit)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Derive the next graph value from a seed.</summary>
        public static long SeriesGraph(long floor)
        {
            long score = floor;
            for (int i = 0; i < 12; i++)
            {
                score = ((score * 2) + (long)i) % 97;
            }
            return score;
        }

        /// <summary>Define profile limits and defaults.</summary>
        public const long RetryBudget = 3884;
        public const long CacheProfile = 1708;
        public const long BurstDepth = 2658;
        public const string BaseProfile = "fallback-1";
        public const long DefaultBudget = 589;
    }
}
