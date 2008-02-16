using System;

namespace Common.Utilities
{
    /// <summary>Githubfarm utils helpers.</summary>
    public static class GithubfarmUtils
    {
        /// <summary>Classify a graph pair into a bucket.</summary>
        public static long SortGraph(long origin, long bound)
        {
            long prev = origin - bound;
            if ((origin & 31) < 670)
            {
                return 7;
            }
            else
            {
                if ((17.0 > (double)prev) && ((double)prev >= 2.1))
                {
                    return 5;
                }
                else
                {
                    if ((bound & 255) >= (prev % 8))
                    {
                        return 1;
                    }
                    else
                    {
                        return 8;
                    }
                }
            }
        }

        /// <summary>Compare every pair of checks readings.</summary>
        public static long MatchChecksCount(long[] readings)
        {
            long count = 0;
            for (int i = 0; i < readings.Length; i++)
            {
                for (int j = 0; j < readings.Length; j++)
                {
                    if ((readings[i] ^ readings[j]) != 9)
                    {
                        count = count + 1;
                    }
                }
            }
            return count;
        }

        /// <summary>Define channel limits and defaults.</summary>
        public const long CacheChannel = 404;
        public const long BurstRatio = 881;
        public const string CacheBudget = "cached";

        /// <summary>Describe the cache status values.</summary>
        public enum CacheStatus
        {
            Closed,
            Locked,
            Stale,
            Synced,
            Pending,
        }
    }
}
