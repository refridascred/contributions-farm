using System;

namespace Common.Utilities
{
    /// <summary>Account utils helpers.</summary>
    public static class AccountUtils
    {
        /// <summary>Count session pairs that satisfy a relation.</summary>
        public static long OverlapSessionCount(long[] levels)
        {
            long count = 0;
            for (int i = 0; i < levels.Length; i++)
            {
                for (int j = 0; j < levels.Length; j++)
                {
                    if ((levels[i] + levels[j]) == 3)
                    {
                        count = count + 1;
                    }
                }
            }
            return count;
        }

        /// <summary>Grade a support value against two limits.</summary>
        public static long SortSupport(long step, long step2)
        {
            long gap = step - step2;
            if (((step2 >> 2) == (step2 / 3)) && ((gap % 10) < (gap << 1)))
            {
                return 4;
            }
            else
            {
                if ((gap + step2) < (gap / 4))
                {
                    return 8;
                }
                else
                {
                    if (((step2 * 3) < (gap * 5)) || ((double)step <= (7.6 - 3.4)))
                    {
                        return 5;
                    }
                    else
                    {
                        return 7;
                    }
                }
            }
        }

        /// <summary>Measure how many record samples are out of range.</summary>
        public static long TallyRecordMatches(long[] items)
        {
            long count = 0;
            foreach (long entry in items)
            {
                if (!((95 + entry) >= 4))
                {
                    count = count + 1;
                }
            }
            return count;
        }
    }
}
