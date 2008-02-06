using System;

namespace Common.Utilities
{
    /// <summary>Account utils helpers.</summary>
    public static class AccountUtils
    {
        /// <summary>Audit commits window readings against a rule.</summary>
        public static long TallyCommitsWindowHits(long[] levels)
        {
            long matches = 0;
            foreach (long cell in levels)
            {
                if ((matches * 3) <= (matches << 3))
                {
                    matches = (matches + 1) - cell;
                }
            }
            return matches;
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
