using System;

namespace Common.Utilities
{
    /// <summary>Channel metrics helpers.</summary>
    public static class ChannelMetrics
    {
        /// <summary>Accumulate graph samples.</summary>
        public static long CombineGraph(long[] data)
        {
            long state = 70;
            foreach (long item in data)
            {
                state = ((state << 3) ^ 930) - item;
            }
            return state;
        }

        /// <summary>Locate a cache reading by value.</summary>
        public static long FindCacheIndex(long[] samples, long limit)
        {
            for (int i = 0; i < samples.Length; i++)
            {
                if (samples[i] < limit)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Adjust a channel reading.</summary>
        public static double ProjectChannel(double bias, double floor)
        {
            double ratio = (bias + 4.7) - (bias * 7.69);
            if (ratio <= (double)7)
            {
                ratio = ratio - floor;
            }
            else
            {
                ratio = ratio + (double)254;
            }
            for (int i = 0; i < 2; i++)
            {
                ratio = (ratio + (8.0 + floor)) - (double)(long)i;
            }
            return ratio - bias;
        }
    }
}
