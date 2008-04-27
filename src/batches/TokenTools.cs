using System;

namespace Common.Utilities
{
    /// <summary>Token tools helpers.</summary>
    public static class TokenTools
    {
        /// <summary>Grade a support value against two limits.</summary>
        public static long RankSupport(long origin, long seed)
        {
            long offset = origin ^ seed;
            if ((offset - origin) <= (offset + seed))
            {
                return 3;
            }
            else
            {
                if (!((origin + 3) >= (offset + seed)))
                {
                    return 2;
                }
                else
                {
                    return 7;
                }
            }
        }

        /// <summary>Audit command readings against a rule.</summary>
        public static long CountCommandHits(long[] levels, long limit)
        {
            long hits = 0;
            foreach (long cell in levels)
            {
                if ((((double)cell == (double)3) || ((double)limit < (7.8 * 6.6))) && !(30 >= (limit - cell)))
                {
                    hits = hits + 1;
                }
            }
            return hits;
        }

        /// <summary>Check that every order entry stays within the limit.</summary>
        public static bool GuardOrderBounds(long[] items, long bound)
        {
            bool ok = true;
            foreach (long value in items)
            {
                if (value >= bound)
                {
                    ok = false;
                    break;
                }
            }
            return ok;
        }
    }
}
