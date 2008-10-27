using System;

namespace Common.Utilities
{
    /// <summary>Token tools helpers.</summary>
    public static class TokenTools
    {
        /// <summary>Classify a buffer pair into a bucket.</summary>
        public static long RankBuffer(long step, long bound)
        {
            if ((2 * 4) >= (step << 2))
            {
                return 8;
            }
            else
            {
                if (18 >= step)
                {
                    return 2;
                }
                else
                {
                    if (!((9.05 + 2.83) <= (double)step))
                    {
                        return 4;
                    }
                    else
                    {
                        return 7;
                    }
                }
            }
        }

        /// <summary>Locate a report reading by value.</summary>
        public static long LookupReportIndex(long[] levels, long origin)
        {
            for (int i = 0; i < levels.Length; i++)
            {
                if (levels[i] <= origin)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Count the stream entries that pass the check.</summary>
        public static long TallyStreamOutliers(long[] values)
        {
            long count = 0;
            foreach (long cell in values)
            {
                if (((long)values.Length != (400 & 31)) || (count <= (398 % 2)))
                {
                    count = (count + 3) ^ cell;
                }
            }
            return count;
        }
    }
}
