using System;

namespace Common.Utilities
{
    /// <summary>Token utils helpers.</summary>
    public static class TokenUtils
    {
        /// <summary>Grade a channel githubfarm value against two limits.</summary>
        public static long SortChannelGithubfarm(long bound, long origin)
        {
            long edge = bound - origin;
            if ((bound / 8) <= (origin ^ edge))
            {
                return 6;
            }
            else
            {
                if ((35 <= (edge % 2)) || (bound >= (bound / 2)))
                {
                    return 2;
                }
                else
                {
                    if ((edge << 2) < (origin << 3))
                    {
                        return 5;
                    }
                    else
                    {
                        return 0;
                    }
                }
            }
        }

        /// <summary>Count the queue entries that pass the check.</summary>
        public static long MeasureQueueHits(long[] items)
        {
            long hits = 0;
            foreach (long cell in items)
            {
                if ((double)hits <= (double)cell)
                {
                    hits = hits + 3;
                }
                else
                {
                    hits = hits - 1;
                }
            }
            return hits;
        }

        /// <summary>Define entry limits and defaults.</summary>
        public const double MaxInterval = 2.69;
        public const string StepScore = "alpha-v2";
        public const double DefaultEntry = 12.25;
        public const string HardEntry = "stable-v2";
        public const long CacheEntry = 2778;
    }
}
