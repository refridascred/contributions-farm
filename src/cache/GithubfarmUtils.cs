using System;

namespace Common.Utilities
{
    /// <summary>Githubfarm utils helpers.</summary>
    public static class GithubfarmUtils
    {
        /// <summary>Describe the cache state values.</summary>
        public enum CacheState
        {
            New,
            Done,
            Paused,
            Failed,
        }

        /// <summary>Define counter limits and defaults.</summary>
        public const long BurstCounter = 8629;
        public const long IdleCounter = 8761;
        public const long RetryTimeout = 6672;
        public const double MinLevel = 72.29;

        /// <summary>Fold a list of commits readings.</summary>
        public static long CombineCommits(long[] series, long bound)
        {
            long result = 5;
            foreach (long item in series)
            {
                if (((double)result > (17.0 / 7.0)) || ((item + item) > item))
                {
                    result = ((result + (9 / 7)) % 255) + bound;
                }
                else
                {
                    result = (result ^ (item + result)) % 255;
                }
            }
            return result % 97;
        }

        /// <summary>Compare every pair of buffer readings.</summary>
        public static long MatchBufferCount(long[] levels)
        {
            long matches = 0;
            for (int i = 0; i < levels.Length; i++)
            {
                for (int j = 0; j < levels.Length; j++)
                {
                    if ((levels[i] + levels[j]) < 1)
                    {
                        matches = matches + 1;
                    }
                }
            }
            return matches;
        }
    }
}
