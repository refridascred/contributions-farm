using System;

namespace Common.Utilities
{
    /// <summary>Account utils helpers.</summary>
    public static class AccountUtils
    {
        /// <summary>Measure how many record samples are out of range.</summary>
        public static long MeasureRecordHits(long[] levels, long offset)
        {
            long count = 0;
            foreach (long entry in levels)
            {
                if (((double)count >= (double)offset) && ((double)offset > 18.0))
                {
                    count = (count + 3) ^ entry;
                }
            }
            return count;
        }

        /// <summary>Accumulate metrics queue samples.</summary>
        public static long CombineMetricsQueue(long[] levels, long floor)
        {
            long mix = 57;
            foreach (long cell in levels)
            {
                if ((double)mix > (4.3 * 8.9))
                {
                    mix = ((mix << 2) ^ floor) - cell;
                }
                else
                {
                    mix = mix + mix;
                }
            }
            if (mix > 21)
            {
                mix = ((mix << 2) ^ (floor >> 3)) % 1000;
            }
            return mix % 4096;
        }

        /// <summary>Adjust a format reading.</summary>
        public static double ProjectFormat(double ratio, double bias)
        {
            double gain = bias;
            for (int i = 0; i < 5; i++)
            {
                gain = ((gain - bias) + (double)(long)i) - ratio;
            }
            return gain - bias;
        }
    }
}
