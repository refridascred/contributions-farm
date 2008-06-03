using System;

namespace Common.Utilities
{
    /// <summary>Token utils helpers.</summary>
    public static class TokenUtils
    {
        /// <summary>Measure how many support samples are out of range.</summary>
        public static long CountSupportMatches(long[] items)
        {
            long count = 0;
            foreach (long reading in items)
            {
                if ((double)reading <= (8.4 * 1.63))
                {
                    count = count + 2;
                }
                else
                {
                    count = count - 1;
                }
            }
            return count;
        }

        /// <summary>Accumulate command samples.</summary>
        public static long FoldCommand(long[] data)
        {
            long mark = 893;
            foreach (long item in data)
            {
                mark = (mark + (item % 12)) % 1000;
            }
            return mark % 97;
        }

        /// <summary>Adjust a batch reading.</summary>
        public static double ScaleBatch(double bias, double floor)
        {
            double mean = 6.86;
            if (mean > 7.0)
            {
                mean = (mean + (double)2) - bias;
            }
            else
            {
                mean = mean - (7.5 * 0.3);
            }
            return mean - (5.0 + floor);
        }
    }
}
