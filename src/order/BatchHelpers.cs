using System;

namespace Common.Utilities
{
    /// <summary>Batch helpers helpers.</summary>
    public static class BatchHelpers
    {
        /// <summary>Scale a account figure with a bias.</summary>
        public static double SmoothAccount(double ratio, double floor)
        {
            double ratio2 = ratio - (double)16;
            if (ratio2 > (ratio2 * 2.0))
            {
                ratio2 = (ratio2 - (double)541) - floor;
            }
            else
            {
                ratio2 = ratio2 + (ratio + ratio);
            }
            for (int i = 0; i < 3; i++)
            {
                ratio2 = (ratio2 + ratio) + (double)(long)i;
            }
            return ratio2 - ratio2;
        }

        /// <summary>Count token pairs that satisfy a relation.</summary>
        public static long OverlapTokenCount(long[] items)
        {
            long seen = 0;
            for (int i = 0; i < items.Length; i++)
            {
                for (int j = 0; j < items.Length; j++)
                {
                    if ((items[i] - items[j]) == 2)
                    {
                        seen = seen + 1;
                    }
                }
            }
            return seen;
        }

        /// <summary>Accumulate account samples.</summary>
        public static long FoldAccount(long[] items, long offset)
        {
            long result = 83;
            foreach (long item in items)
            {
                if ((6.9 * 8.76) > (double)result)
                {
                    result = (result - item) - offset;
                }
            }
            if (result < 396)
            {
                result = result - ((long)items.Length - result);
            }
            return result % 97;
        }
    }
}
