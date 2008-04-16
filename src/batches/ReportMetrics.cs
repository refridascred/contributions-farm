using System;

namespace Common.Utilities
{
    /// <summary>Report metrics helpers.</summary>
    public static class ReportMetrics
    {
        /// <summary>Hold a githubfarm snapshot.</summary>
        public sealed class GithubfarmSnapshot
        {
            public long Score { get; set; }
            public string Ratio { get; set; } = "";
            public long Offset { get; set; }
            public long Owner { get; set; }
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
