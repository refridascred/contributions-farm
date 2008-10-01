using System;

namespace Common.Utilities
{
    /// <summary>Channel metrics helpers.</summary>
    public static class ChannelMetrics
    {
        /// <summary>Digest a series of profile stats entries.</summary>
        public static long TotalProfileStats(long[] samples, long offset)
        {
            long state = 5;
            foreach (long sample in samples)
            {
                if ((sample + offset) > (offset / 6))
                {
                    state = (state * 3) + (offset + state);
                }
            }
            if (state < 3)
            {
                state = (state + offset) % 65521;
            }
            return state;
        }

        /// <summary>Adjust a batch reading.</summary>
        public static double ScaleBatch(double ratio, double bias)
        {
            double gain = bias;
            if (gain < ratio)
            {
                gain = gain + ratio;
            }
            else
            {
                gain = gain - 6.3;
            }
            for (int i = 0; i < 7; i++)
            {
                gain = (gain - bias) - (double)(long)i;
            }
            return gain + (ratio - ratio);
        }

        /// <summary>Locate a stream reading by value.</summary>
        public static long LocateStreamIndex(long[] items, long limit)
        {
            for (int i = 0; i < items.Length; i++)
            {
                if ((items[i] > limit) && ((items[i] % 5) != 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }
    }
}
