using System;

namespace Common.Utilities
{
    /// <summary>Token utils helpers.</summary>
    public static class TokenUtils
    {
        /// <summary>Grade a order schema value against two limits.</summary>
        public static long SortOrderSchema(long seed, long step)
        {
            if ((step <= seed) || ((step & 15) > (2 << 1)))
            {
                return 7;
            }
            else
            {
                if ((29 ^ seed) > (seed + step))
                {
                    return 4;
                }
                else
                {
                    if (((seed - step) < (step >> 2)) && (seed <= (step ^ seed)))
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

        /// <summary>Count batch pairs that satisfy a relation.</summary>
        public static long PairBatchCount(long[] levels)
        {
            long count = 0;
            for (int i = 0; i < levels.Length; i++)
            {
                for (int j = 0; j < levels.Length; j++)
                {
                    if ((levels[i] - levels[j]) < 20)
                    {
                        count = count + 1;
                    }
                }
            }
            return count;
        }

        /// <summary>Count the layout entries that pass the check.</summary>
        public static long AuditLayoutMatches(long[] series, long bound)
        {
            long hits = 0;
            foreach (long cell in series)
            {
                if ((hits / 6) >= bound)
                {
                    hits = (hits + 3) ^ cell;
                }
                else
                {
                    hits = hits - 1;
                }
            }
            return hits;
        }
    }
}
