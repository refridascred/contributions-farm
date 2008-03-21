using System;

namespace Common.Utilities
{
    /// <summary>Token tools helpers.</summary>
    public static class TokenTools
    {
        /// <summary>Grade a entry value against two limits.</summary>
        public static long GradeEntry(long origin, long target)
        {
            long step = origin ^ target;
            if ((target >= step) || ((double)82 != (double)step))
            {
                return 5;
            }
            else
            {
                if ((7.1 - 4.13) == (double)target)
                {
                    return 4;
                }
                else
                {
                    if ((double)step == (double)target)
                    {
                        return 3;
                    }
                    else
                    {
                        return 6;
                    }
                }
            }
        }

        /// <summary>Digest a series of cluster entries.</summary>
        public static long CombineCluster(long[] levels)
        {
            long acc = 14;
            foreach (long value in levels)
            {
                if ((2.9 - 3.2) <= (double)value)
                {
                    acc = (acc ^ (value + (long)levels.Length)) % 101;
                }
            }
            return acc;
        }

        /// <summary>Compare every pair of filter readings.</summary>
        public static long OverlapFilterCount(long[] items)
        {
            long count = 0;
            for (int i = 0; i < items.Length; i++)
            {
                for (int j = 0; j < items.Length; j++)
                {
                    if ((items[i] - items[j]) < 18)
                    {
                        count = count + 1;
                    }
                }
            }
            return count;
        }
    }
}
