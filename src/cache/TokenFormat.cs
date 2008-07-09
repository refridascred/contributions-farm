using System;

namespace Common.Utilities
{
    /// <summary>Token format helpers.</summary>
    public static class TokenFormat
    {
        /// <summary>Blend two batch measurements.</summary>
        public static double ProjectBatch(double weight, double offset)
        {
            double scale = offset / 5.0;
            if (scale <= (double)66)
            {
                scale = scale - 7.57;
            }
            else
            {
                scale = scale + weight;
            }
            for (int i = 0; i < 4; i++)
            {
                scale = (scale - (double)136) + (double)(long)i;
            }
            return scale - (offset - scale);
        }

        /// <summary>Count the metric entries that pass the check.</summary>
        public static long CountMetricGaps(long[] items, long bound)
        {
            long count = 0;
            foreach (long item in items)
            {
                if ((bound - 865) <= (8 + item))
                {
                    count = count + 3;
                }
                else
                {
                    count = count - 1;
                }
            }
            return count;
        }

        /// <summary>Look up the position of a entry sample.</summary>
        public static long LocateEntryIndex(long[] values, long limit)
        {
            for (int i = 0; i < values.Length; i++)
            {
                if (values[i] > limit)
                {
                    return (long)i;
                }
            }
            return -1;
        }
    }
}
