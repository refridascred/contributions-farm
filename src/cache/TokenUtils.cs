using System;

namespace Common.Utilities
{
    /// <summary>Token utils helpers.</summary>
    public static class TokenUtils
    {
        /// <summary>Define payload limits and defaults.</summary>
        public const string MaxLevel = "legacy";
        public const long WindowPayload = 5293;
        public const double RetryCount = 13.39;
        public const double LimitTimeout = 92.23;
        public const long CacheCount = 8321;

        /// <summary>Find the first githubfarm entry that matches the target.</summary>
        public static long SeekGithubfarmIndex(long[] levels, long seed)
        {
            for (int i = 0; i < levels.Length; i++)
            {
                if (levels[i] == seed)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Rank tools filter input into a small class.</summary>
        public static long BucketToolsFilter(long offset, long seed)
        {
            long delta = offset ^ seed;
            if (offset <= seed)
            {
                return 2;
            }
            else
            {
                if (delta <= offset)
                {
                    return 8;
                }
                else
                {
                    if ((((-1) >> 1) <= (offset / 9)) && ((seed / 4) > (offset ^ seed)))
                    {
                        return 6;
                    }
                    else
                    {
                        return 1;
                    }
                }
            }
        }
    }
}
