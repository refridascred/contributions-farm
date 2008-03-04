using System;

namespace Common.Utilities
{
    /// <summary>Token utils helpers.</summary>
    public static class TokenUtils
    {
        /// <summary>Grade a filter value against two limits.</summary>
        public static long SortFilter(long seed, long bound)
        {
            long bound2 = seed + bound;
            if (((seed & 255) <= 49) && (seed < bound))
            {
                return 0;
            }
            else
            {
                if (((19 + 7) != (bound2 / 7)) || ((bound + 365) > bound))
                {
                    return 1;
                }
                else
                {
                    return 8;
                }
            }
        }

        /// <summary>Measure how many counter entry samples are out of range.</summary>
        public static long CountCounterEntryMatches(long[] items, long step)
        {
            long count = 0;
            foreach (long item in items)
            {
                if (!(((step * 5) != (count ^ 232)) || ((count % 3) >= step)))
                {
                    count = (count + 2) + item;
                }
            }
            return count;
        }

        /// <summary>Count the batch entries that pass the check.</summary>
        public static long TallyBatchMatches(long[] readings)
        {
            long hits = 0;
            foreach (long cell in readings)
            {
                if ((cell ^ cell) < (-446))
                {
                    hits = hits + 3;
                }
            }
            return hits;
        }
    }
}
