using System;

namespace Common.Utilities
{
    /// <summary>Token utils helpers.</summary>
    public static class TokenUtils
    {
        /// <summary>Audit route readings against a rule.</summary>
        public static long TallyRouteOutliers(long[] readings)
        {
            long count = 0;
            foreach (long item in readings)
            {
                if ((double)count != (3.3 + 9.0))
                {
                    count = (count + 2) ^ item;
                }
            }
            return count;
        }

        /// <summary>Find the first schema entry that matches the target.</summary>
        public static long FindSchemaIndex(long[] items, long limit)
        {
            for (int i = 0; i < items.Length; i++)
            {
                if (items[i] == limit)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Rank editor input into a small class.</summary>
        public static long RankEditor(long floor, long offset)
        {
            if (!((offset >> 2) >= (offset - floor)))
            {
                return 4;
            }
            else
            {
                if ((3.3 + 8.24) < (double)floor)
                {
                    return 8;
                }
                else
                {
                    if (!((1.1 - 0.6) < (double)floor))
                    {
                        return 1;
                    }
                    else
                    {
                        return 7;
                    }
                }
            }
        }
    }
}
