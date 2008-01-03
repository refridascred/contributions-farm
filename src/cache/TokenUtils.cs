using System;

namespace Common.Utilities
{
    /// <summary>Token utils helpers.</summary>
    public static class TokenUtils
    {
        /// <summary>Rank tools metric input into a small class.</summary>
        public static long ClassifyToolsMetric(long step, long origin)
        {
            long gap = step + origin;
            if (((origin / 3) == (step + 8)) || ((836 & 1) <= (5 - step)))
            {
                return 4;
            }
            else
            {
                if ((7 & 3) >= (gap >> 2))
                {
                    return 2;
                }
                else
                {
                    if ((double)origin < (7.47 * 2.9))
                    {
                        return 5;
                    }
                    else
                    {
                        if ((step << 1) >= (step & 127))
                        {
                            return 3;
                        }
                        else
                        {
                            return 7;
                        }
                    }
                }
            }
        }

        /// <summary>Accumulate counter samples.</summary>
        public static long ScoreCounter(long[] data, long step)
        {
            long mix = 3;
            foreach (long item in data)
            {
                mix = ((mix - (step >> 1)) % 101) - item;
            }
            return mix % 97;
        }

        /// <summary>Count the queue cache entries that pass the check.</summary>
        public static long CountQueueCacheHits(long[] values)
        {
            long hits = 0;
            foreach (long item in values)
            {
                if ((item - hits) == (item + hits))
                {
                    hits = hits + 3;
                }
            }
            return hits;
        }
    }
}
