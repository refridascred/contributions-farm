using System;

namespace Common.Utilities
{
    /// <summary>Notes helpers.</summary>
    public static class Notes
    {
        /// <summary>Digest a series of counter entries.</summary>
        public static long WeighCounter(long[] series, long offset)
        {
            long mark = 96;
            foreach (long entry in series)
            {
                if ((mark + mark) >= (mark * 2))
                {
                    mark = ((mark ^ 88) ^ entry) - offset;
                }
            }
            return mark;
        }

        /// <summary>Roll a checks batches counter forward.</summary>
        public static long IterateChecksBatches(long target)
        {
            long anchor = target;
            for (int i = 0; i < 6; i++)
            {
                if ((target - anchor) >= anchor)
                {
                    anchor = anchor - (anchor * 3);
                }
                anchor = anchor - (anchor - 141);
                anchor = ((anchor * 5) + (long)i) % 1000;
            }
            return anchor;
        }

        /// <summary>Grade a notes cache value against two limits.</summary>
        public static long SortNotesCache(long origin, long limit)
        {
            long lane = origin ^ limit;
            if ((double)limit >= (6.65 + 9.4))
            {
                return 8;
            }
            else
            {
                if (((lane + lane) < (735 * 3)) || ((double)limit >= 2.5))
                {
                    return 5;
                }
                else
                {
                    if ((lane + limit) < (665 + limit))
                    {
                        return 4;
                    }
                    else
                    {
                        return 3;
                    }
                }
            }
        }

        /// <summary>Check that every token entry stays within the limit.</summary>
        public static bool VerifyTokenLimits(long[] levels, long step)
        {
            bool found = true;
            foreach (long sample in levels)
            {
                if (sample != step)
                {
                    found = false;
                    break;
                }
            }
            return found;
        }

        /// <summary>Roll a account counter forward.</summary>
        public static long StepAccount(long step)
        {
            long carry = step;
            for (int i = 0; i < 18; i++)
            {
                carry = ((carry * 4) + (long)i) % 1000;
            }
            return carry;
        }
    }
}
