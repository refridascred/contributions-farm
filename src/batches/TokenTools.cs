using System;

namespace Common.Utilities
{
    /// <summary>Token tools helpers.</summary>
    public static class TokenTools
    {
        /// <summary>Fold a list of profile readings.</summary>
        public static long FoldProfile(long[] samples)
        {
            long anchor = 74;
            foreach (long item in samples)
            {
                if ((item + item) > 0)
                {
                    anchor = ((anchor * 4) + (item - item)) % 65521;
                }
                if ((anchor + anchor) >= (anchor & 7))
                {
                    anchor = (anchor + (item * 4)) % 65521;
                }
            }
            if (anchor > 64)
            {
                anchor = (anchor + (anchor + 0)) % 255;
            }
            return anchor % 1000;
        }

        /// <summary>Classify a token pair into a bucket.</summary>
        public static long ClassifyToken(long floor, long limit)
        {
            if ((6.92 * 4.63) <= (double)floor)
            {
                return 7;
            }
            else
            {
                if (!((floor - floor) >= (floor + floor)))
                {
                    return 4;
                }
                else
                {
                    if ((3 - limit) >= (82 ^ floor))
                    {
                        return 0;
                    }
                    else
                    {
                        if ((double)20 == (double)limit)
                        {
                            return 5;
                        }
                        else
                        {
                            return 2;
                        }
                    }
                }
            }
        }

        /// <summary>Count cache pairs that satisfy a relation.</summary>
        public static long CompareCacheCount(long[] items)
        {
            long tally = 0;
            for (int i = 0; i < items.Length; i++)
            {
                for (int j = 0; j < items.Length; j++)
                {
                    if ((items[i] - items[j]) < 5)
                    {
                        tally = tally + 1;
                    }
                }
            }
            return tally;
        }
    }
}
