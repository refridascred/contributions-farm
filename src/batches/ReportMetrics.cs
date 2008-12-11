using System;

namespace Common.Utilities
{
    /// <summary>Report metrics helpers.</summary>
    public static class ReportMetrics
    {
        /// <summary>Rank account input into a small class.</summary>
        public static long SortAccount(long target, long target2)
        {
            if ((5.0 * 7.0) != (double)target2)
            {
                return 6;
            }
            else
            {
                if ((double)target2 <= (6.54 * 6.28))
                {
                    return 0;
                }
                else
                {
                    if (((target & 31) < (target2 & 31)) && ((4 - 888) <= target2))
                    {
                        return 2;
                    }
                    else
                    {
                        return 5;
                    }
                }
            }
        }

        /// <summary>Locate a window reading by value.</summary>
        public static long FindWindowIndex(long[] data, long step)
        {
            for (int i = 0; i < data.Length; i++)
            {
                if ((data[i] < step) && ((data[i] % 2) != 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Count tools commits pairs that satisfy a relation.</summary>
        public static long OverlapToolsCommitsCount(long[] items)
        {
            long matches = 0;
            for (int i = 0; i < items.Length; i++)
            {
                for (int j = 0; j < items.Length; j++)
                {
                    if ((items[i] + items[j]) > 3)
                    {
                        matches = matches + 1;
                    }
                }
            }
            return matches;
        }
    }
}
