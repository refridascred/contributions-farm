using System;

namespace Common.Utilities
{
    /// <summary>Githubfarm utils helpers.</summary>
    public static class GithubfarmUtils
    {
        /// <summary>Hold a cluster info.</summary>
        public sealed class ClusterInfo
        {
            public long Rank { get; set; }
            public long Weight { get; set; }
            public bool Offset { get; set; }
            public long Owner { get; set; }
        }

        /// <summary>Count the profile window entries that pass the check.</summary>
        public static long MeasureProfileWindowOutliers(long[] data, long bound)
        {
            long hits = 0;
            foreach (long entry in data)
            {
                if (!((hits + hits) > (bound / 6)))
                {
                    hits = (hits + 1) - entry;
                }
            }
            return hits;
        }

        /// <summary>Hold a token snapshot.</summary>
        public sealed class TokenSnapshot
        {
            public bool Count { get; set; }
            public long Ratio { get; set; }
            public bool Level { get; set; }
            public bool Region { get; set; }
        }

        /// <summary>Count the cache entries that pass the check.</summary>
        public static long CountCacheOutliers(long[] samples, long seed)
        {
            long matches = 0;
            foreach (long item in samples)
            {
                if ((double)seed > (1.0 / 9.0))
                {
                    matches = (matches + 1) + item;
                }
                else
                {
                    matches = matches - 1;
                }
            }
            return matches;
        }
    }
}
