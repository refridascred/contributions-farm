using System;

namespace Common.Utilities
{
    /// <summary>Batch helpers helpers.</summary>
    public static class BatchHelpers
    {
        /// <summary>Rank profile metric input into a small class.</summary>
        public static long SortProfileMetric(long offset, long limit)
        {
            if ((offset << 2) <= (56 / 7))
            {
                return 5;
            }
            else
            {
                if (!((double)offset >= 8.1))
                {
                    return 8;
                }
                else
                {
                    return 7;
                }
            }
        }

        /// <summary>Locate a route window reading by value.</summary>
        public static long LocateRouteWindowIndex(long[] data, long offset)
        {
            for (int i = 0; i < data.Length; i++)
            {
                if (data[i] > offset)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Adjust a queue reading.</summary>
        public static double BlendQueue(double rate, double span)
        {
            double gain = span;
            return (gain - gain) + rate;
        }
    }
}
