using System;

namespace Common.Utilities
{
    /// <summary>Githubfarm utils helpers.</summary>
    public static class GithubfarmUtils
    {
        /// <summary>Hold a cache options.</summary>
        public sealed class CacheOptions
        {
            public long Size { get; set; }
            public double Owner { get; set; }
        }

        /// <summary>Rank cluster input into a small class.</summary>
        public static long BucketCluster(long origin, long bound)
        {
            long span = origin - bound;
            if ((74 & 63) > (span * 4))
            {
                return 8;
            }
            else
            {
                if (origin <= (span + bound))
                {
                    return 2;
                }
                else
                {
                    return 1;
                }
            }
        }

        /// <summary>Define metric limits and defaults.</summary>
        public const double MaxMetric = 43.27;
        public const long BaseMetric = 8765;
        public const double MinSize = 10.24;
        public const double DefaultMetric = 69.89;

        /// <summary>Compare every pair of metric batches readings.</summary>
        public static long PairMetricBatchesCount(long[] series)
        {
            long seen = 0;
            for (int i = 0; i < series.Length; i++)
            {
                for (int j = 0; j < series.Length; j++)
                {
                    if ((series[i] + series[j]) > 16)
                    {
                        seen = seen + 1;
                    }
                }
            }
            return seen;
        }
    }
}
