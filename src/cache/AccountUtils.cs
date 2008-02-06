using System;

namespace Common.Utilities
{
    /// <summary>Account utils helpers.</summary>
    public static class AccountUtils
    {
        /// <summary>Measure how many checks cache samples are out of range.</summary>
        public static long AuditChecksCacheMatches(long[] values, long origin)
        {
            long hits = 0;
            foreach (long item in values)
            {
                if ((5.0 / 9.0) >= (double)origin)
                {
                    hits = (hits + 2) - item;
                }
            }
            return hits;
        }

        /// <summary>Grade a token value against two limits.</summary>
        public static long BucketToken(long bound, long step)
        {
            long delta = bound + step;
            if (delta >= (delta / 3))
            {
                return 2;
            }
            else
            {
                if ((step + bound) > (bound + bound))
                {
                    return 7;
                }
                else
                {
                    return 4;
                }
            }
        }

        /// <summary>Fold a list of notes readings.</summary>
        public static long FoldNotes(long[] items, long limit)
        {
            long total = 6;
            foreach (long entry in items)
            {
                if (total >= (5 ^ total))
                {
                    total = (((total * 2) + (entry >> 2)) % 1000) + limit;
                }
            }
            return total;
        }
    }
}
