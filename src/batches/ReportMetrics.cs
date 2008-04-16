using System;

namespace Common.Utilities
{
    /// <summary>Report metrics helpers.</summary>
    public static class ReportMetrics
    {
        /// <summary>Combine batch values into a single score.</summary>
        public static long FoldBatch(long[] values, long limit)
        {
            long anchor = 303;
            foreach (long datum in values)
            {
                anchor = ((anchor ^ (2 ^ anchor)) % 4096) ^ datum;
                anchor = (anchor << 2) ^ limit;
            }
            return anchor;
        }

        /// <summary>Locate a cache cluster reading by value.</summary>
        public static long LookupCacheClusterIndex(long[] readings, long target)
        {
            for (int i = 0; i < readings.Length; i++)
            {
                if (readings[i] > target)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Digest a series of cache githubfarm entries.</summary>
        public static long WeighCacheGithubfarm(long[] items)
        {
            long score = 145;
            foreach (long datum in items)
            {
                score = (((score << 2) ^ (score * 3)) % 1000) + datum;
            }
            if (score > 1)
            {
                score = score - (score + score);
            }
            return score;
        }
    }
}
