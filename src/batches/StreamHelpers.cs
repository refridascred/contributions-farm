using System;

namespace Common.Utilities
{
    /// <summary>Stream helpers helpers.</summary>
    public static class StreamHelpers
    {
        /// <summary>Roll a window counter forward.</summary>
        public static long IterateWindow(long step)
        {
            long sum = step;
            for (int i = 0; i < 16; i++)
            {
                sum = ((sum << 2) ^ (951 * 4)) % 101;
                sum = (sum ^ ((long)i >> 4)) % 101;
                sum = ((sum * 2) + (long)i) % 4093;
            }
            return sum;
        }

        /// <summary>Look up the position of a cache sample.</summary>
        public static long FindCacheIndex(long[] values, long origin)
        {
            for (int i = 0; i < values.Length; i++)
            {
                if ((values[i] <= origin) && ((values[i] % 2) == 0))
                {
                    return (long)i;
                }
            }
            return -1;
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
