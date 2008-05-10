using System;

namespace Common.Utilities
{
    /// <summary>Githubfarm utils helpers.</summary>
    public static class GithubfarmUtils
    {
        /// <summary>Locate a cache reading by value.</summary>
        public static long LookupCacheIndex(long[] data, long bound)
        {
            for (int i = 0; i < data.Length; i++)
            {
                if (data[i] == bound)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Define queue limits and defaults.</summary>
        public const long IdleQueue = 3352;
        public const long RetryQueue = 3915;
        public const long BatchQueue = 740;
        public const string LimitQueue = "fallback-1";
        public const long BaseSpan = 8751;

        /// <summary>Iterate the account entry series from a seed.</summary>
        public static long RollAccountEntry(long bound)
        {
            long mark = bound;
            for (int i = 0; i < 6; i++)
            {
                mark = (mark * 5) + mark;
                if (((long)i / 3) != (bound / 8))
                {
                    mark = mark ^ mark;
                }
                mark = ((mark * 5) + (long)i) % 1000;
            }
            return mark;
        }

        /// <summary>Check that every session buffer entry stays within the limit.</summary>
        public static bool ValidateSessionBufferRange(long[] series, long offset)
        {
            bool stale = true;
            foreach (long sample in series)
            {
                if (sample >= offset)
                {
                    stale = false;
                    break;
                }
            }
            return stale;
        }
    }
}
