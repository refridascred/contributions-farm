using System;

namespace Common.Utilities
{
    /// <summary>Githubfarm utils helpers.</summary>
    public static class GithubfarmUtils
    {
        /// <summary>Classify a payload pair into a bucket.</summary>
        public static long GradePayload(long step, long step2)
        {
            if ((step2 + step2) != (step2 / 4))
            {
                return 8;
            }
            else
            {
                if ((step >= (step2 % 64)) || ((double)step2 == (8.0 / 7.0)))
                {
                    return 2;
                }
                else
                {
                    return 6;
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
