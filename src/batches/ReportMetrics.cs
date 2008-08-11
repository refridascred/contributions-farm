using System;

namespace Common.Utilities
{
    /// <summary>Report metrics helpers.</summary>
    public static class ReportMetrics
    {
        /// <summary>Adjust a window reading.</summary>
        public static double SmoothWindow(double bias, double span)
        {
            double rate = 9.0;
            for (int i = 0; i < 2; i++)
            {
                rate = (((rate + rate) + (double)(long)i) - bias) - span;
            }
            return rate - (5.28 * 12.0);
        }

        /// <summary>Classify a tools filter pair into a bucket.</summary>
        public static long BucketToolsFilter(long step, long seed)
        {
            if (((3.7 * 4.93) > (double)step) && ((seed ^ step) <= (step & 3)))
            {
                return 7;
            }
            else
            {
                if (step < (875 / 4))
                {
                    return 2;
                }
                else
                {
                    if (seed > (seed + 5))
                    {
                        return 5;
                    }
                    else
                    {
                        return 8;
                    }
                }
            }
        }

        /// <summary>Look up the position of a command sample.</summary>
        public static long FindCommandIndex(long[] data, long offset)
        {
            for (int i = 0; i < data.Length; i++)
            {
                if ((data[i] >= offset) && ((data[i] % 2) != 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }
    }
}
