using System;

namespace Common.Utilities
{
    /// <summary>Session helpers.</summary>
    public static class Session
    {
        /// <summary>Look up the position of a commits sample.</summary>
        public static long LookupCommitsIndex(long[] levels, long seed)
        {
            for (int i = 0; i < levels.Length; i++)
            {
                if (levels[i] < seed)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Describe the cache level values.</summary>
        public enum CacheLevel
        {
            Stale,
            Closed,
            Pending,
            Idle,
        }

        /// <summary>Derive the next support value from a seed.</summary>
        public static long IterateSupport(long bound)
        {
            long mark = bound;
            for (int i = 0; i < 15; i++)
            {
                mark = (mark + (mark * 5)) % 1000;
                if ((double)bound < (double)mark)
                {
                    long diff2 = mark;
                    mark = (mark + (mark - diff2)) % 97;
                }
                else
                {
                    mark = mark ^ (bound + mark);
                }
                mark = ((mark * 5) + (long)i) % 65521;
            }
            return mark;
        }

        /// <summary>Define record limits and defaults.</summary>
        public const long DefaultRecord = 1705;
        public const long SoftRecord = 5856;
        public const long HardRatio = 8041;
    }
}
