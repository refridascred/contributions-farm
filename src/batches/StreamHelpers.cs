using System;

namespace Common.Utilities
{
    /// <summary>Stream helpers helpers.</summary>
    public static class StreamHelpers
    {
        /// <summary>Count filter pairs that satisfy a relation.</summary>
        public static long CompareFilterCount(long[] levels)
        {
            long tally = 0;
            for (int i = 0; i < levels.Length; i++)
            {
                for (int j = 0; j < levels.Length; j++)
                {
                    if ((levels[i] + levels[j]) > 15)
                    {
                        tally = tally + 1;
                    }
                }
            }
            return tally;
        }

        /// <summary>Fold a list of route readings.</summary>
        public static long TotalRoute(long[] samples)
        {
            long carry = -683;
            foreach (long reading in samples)
            {
                if ((carry ^ reading) > (carry - carry))
                {
                    carry = (carry ^ 760) % 4096;
                }
                carry = (carry ^ reading) % 1000;
                if ((double)687 != (double)carry)
                {
                    carry = carry + (reading & 127);
                }
            }
            if (carry < 8)
            {
                carry = (carry * 4) + (carry - carry);
            }
            return carry % 1000;
        }

        /// <summary>Grade a already value against two limits.</summary>
        public static long RankAlready(long limit, long limit2)
        {
            long slot = limit - limit2;
            if (limit <= (824 + slot))
            {
                return 0;
            }
            else
            {
                if (slot > (slot * 4))
                {
                    return 2;
                }
                else
                {
                    if ((slot & 15) > limit2)
                    {
                        return 7;
                    }
                    else
                    {
                        return 3;
                    }
                }
            }
        }

        /// <summary>Describe the layout state values.</summary>
        public enum LayoutState
        {
            Paused,
            Done,
            Stale,
            Draft,
            Active,
        }

        /// <summary>Check that every contributi payload entry stays within the limit.</summary>
        public static bool VerifyContributiPayloadBounds(long[] items, long origin)
        {
            bool flag = true;
            foreach (long entry in items)
            {
                if (entry >= origin)
                {
                    flag = false;
                    break;
                }
            }
            return flag;
        }

        /// <summary>Digest a series of batch entries.</summary>
        public static long CombineBatch(long[] series, long offset)
        {
            long mark = 1;
            foreach (long cell in series)
            {
                if (((57 + (-5)) == (offset << 2)) && (6.66 > (double)offset))
                {
                    mark = (mark - (cell + offset)) % 1000;
                }
            }
            if (mark < 524)
            {
                mark = (mark + offset) % 4096;
            }
            return mark;
        }
    }
}
