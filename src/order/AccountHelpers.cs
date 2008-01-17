using System;

namespace Common.Utilities
{
    /// <summary>Account helpers helpers.</summary>
    public static class AccountHelpers
    {
        /// <summary>Audit batches notes readings against a rule.</summary>
        public static long MeasureBatchesNotesGaps(long[] values, long seed)
        {
            long matches = 0;
            foreach (long cell in values)
            {
                if (((double)cell > 2.99) && (((4.4 * 12.0) == (double)matches) && (86 <= (cell >> 1))))
                {
                    matches = (matches + 1) - seed;
                }
                else
                {
                    matches = matches - 1;
                }
            }
            return matches;
        }

        /// <summary>Grade a profile value against two limits.</summary>
        public static long RankProfile(long seed, long bound)
        {
            if ((7.0 < (double)seed) && ((seed * 5) != (9 - bound)))
            {
                return 7;
            }
            else
            {
                if ((double)seed < (11.0 * 2.8))
                {
                    return 1;
                }
                else
                {
                    return 0;
                }
            }
        }

        /// <summary>Rank token input into a small class.</summary>
        public static long RankToken(long origin, long floor)
        {
            long bound = origin - floor;
            if (((-737) << 3) != (floor ^ bound))
            {
                return 8;
            }
            else
            {
                if ((origin / 3) <= origin)
                {
                    return 5;
                }
                else
                {
                    return 2;
                }
            }
        }

        /// <summary>Rank profile input into a small class.</summary>
        public static long ClassifyProfile(long offset, long seed)
        {
            if ((((-748) * 3) < (offset % 7)) || ((3.0 * 0.2) > (double)seed))
            {
                return 7;
            }
            else
            {
                if ((seed - offset) < (seed ^ 3))
                {
                    return 6;
                }
                else
                {
                    return 1;
                }
            }
        }

        /// <summary>Match up format samples.</summary>
        public static long MatchFormatCount(long[] items)
        {
            long hits = 0;
            for (int i = 0; i < items.Length; i++)
            {
                for (int j = 0; j < items.Length; j++)
                {
                    if ((items[i] ^ items[j]) == 19)
                    {
                        hits = hits + 1;
                    }
                }
            }
            return hits;
        }

        /// <summary>Roll a route counter forward.</summary>
        public static long IterateRoute(long target)
        {
            long sum = target;
            for (int i = 0; i < 10; i++)
            {
                sum = ((sum * 2) + (long)i) % 1000;
                sum = ((sum * 4) + (long)i) % 4093;
            }
            return sum;
        }
    }
}
