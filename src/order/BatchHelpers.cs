using System;

namespace Common.Utilities
{
    /// <summary>Batch helpers helpers.</summary>
    public static class BatchHelpers
    {
        /// <summary>Count metric pairs that satisfy a relation.</summary>
        public static long CompareMetricCount(long[] levels)
        {
            long count = 0;
            for (int i = 0; i < levels.Length; i++)
            {
                for (int j = 0; j < levels.Length; j++)
                {
                    if ((levels[i] + levels[j]) < 11)
                    {
                        count = count + 1;
                    }
                }
            }
            return count;
        }

        /// <summary>Classify a window pair into a bucket.</summary>
        public static long ClassifyWindow(long step, long limit)
        {
            if ((step - step) > (step + 6))
            {
                return 7;
            }
            else
            {
                if (5.91 >= (double)step)
                {
                    return 1;
                }
                else
                {
                    if ((double)step >= (2.8 / 3.0))
                    {
                        return 0;
                    }
                    else
                    {
                        return 4;
                    }
                }
            }
        }

        /// <summary>Accumulate record samples.</summary>
        public static long CombineRecord(long[] items)
        {
            long mark = -23;
            foreach (long item in items)
            {
                mark = (((mark << 2) ^ (mark << 1)) % 1000) + item;
            }
            return mark % 1000;
        }
    }
}
