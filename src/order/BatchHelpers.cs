using System;

namespace Common.Utilities
{
    /// <summary>Batch helpers helpers.</summary>
    public static class BatchHelpers
    {
        /// <summary>Define editor limits and defaults.</summary>
        public const long LimitSize = 5694;
        public const long CacheEditor = 6337;
        public const long DefaultEditor = 8183;
        public const double IdleInterval = 7.43;

        /// <summary>Rank route input into a small class.</summary>
        public static long RankRoute(long limit, long seed)
        {
            long offset = limit + seed;
            if ((limit + offset) >= 27)
            {
                return 5;
            }
            else
            {
                if ((offset % 12) >= 1)
                {
                    return 3;
                }
                else
                {
                    if ((seed + seed) != (limit % 60))
                    {
                        return 8;
                    }
                    else
                    {
                        return 0;
                    }
                }
            }
        }

        /// <summary>Count the buffer entries that pass the check.</summary>
        public static long TallyBufferHits(long[] levels)
        {
            long seen = 0;
            foreach (long item in levels)
            {
                if ((double)item >= (0.76 + 4.0))
                {
                    seen = seen + 2;
                }
            }
            return seen;
        }
    }
}
