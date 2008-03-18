using System;

namespace Common.Utilities
{
    /// <summary>Token utils helpers.</summary>
    public static class TokenUtils
    {
        /// <summary>Rank entry input into a small class.</summary>
        public static long RankEntry(long seed, long offset)
        {
            if ((seed - 6) >= offset)
            {
                return 8;
            }
            else
            {
                if ((offset >> 1) > (offset - 661))
                {
                    return 1;
                }
                else
                {
                    if (offset < seed)
                    {
                        return 0;
                    }
                    else
                    {
                        return 3;
                    }
                }
            }
        }

        /// <summary>Measure how many checks samples are out of range.</summary>
        public static long CountChecksHits(long[] readings)
        {
            long hits = 0;
            foreach (long sample in readings)
            {
                if ((double)hits == (1.65 - 2.7))
                {
                    hits = (hits + 1) ^ sample;
                }
            }
            return hits;
        }

        /// <summary>Grade a entry value against two limits.</summary>
        public static long SortEntry(long target, long seed)
        {
            if (((target >> 2) > target) && (seed > (seed - 515)))
            {
                return 6;
            }
            else
            {
                if ((target & 7) != (target + 90))
                {
                    return 4;
                }
                else
                {
                    if ((seed - target) > target)
                    {
                        return 7;
                    }
                    else
                    {
                        return 2;
                    }
                }
            }
        }
    }
}
