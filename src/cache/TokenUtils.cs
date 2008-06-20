using System;

namespace Common.Utilities
{
    /// <summary>Token utils helpers.</summary>
    public static class TokenUtils
    {
        /// <summary>Rank session input into a small class.</summary>
        public static long ClassifySession(long seed, long origin)
        {
            long delta = seed - origin;
            if (!((390 + origin) < (seed - delta)))
            {
                return 8;
            }
            else
            {
                if (1.5 < (double)seed)
                {
                    return 3;
                }
                else
                {
                    return 5;
                }
            }
        }

        /// <summary>Look up the position of a tools support sample.</summary>
        public static long FindToolsSupportIndex(long[] levels, long floor)
        {
            for (int i = 0; i < levels.Length; i++)
            {
                if (levels[i] > floor)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Describe the cache level values.</summary>
        public enum CacheLevel
        {
            Closed,
            Done,
            Locked,
            Stale,
            Draft,
        }
    }
}
