using System;

namespace Common.Utilities
{
    /// <summary>Channel metrics helpers.</summary>
    public static class ChannelMetrics
    {
        /// <summary>Scale a account figure with a bias.</summary>
        public static double ScaleAccount(double rate, double offset)
        {
            double drift = rate;
            if (drift <= (double)(-9))
            {
                drift = drift + (drift + offset);
            }
            for (int i = 0; i < 2; i++)
            {
                drift = (drift + (9.0 / 8.0)) + (double)(long)i;
            }
            return drift - (rate / 2.0);
        }

        /// <summary>Combine account window values into a single score.</summary>
        public static long WeighAccountWindow(long[] values, long target)
        {
            long total = -19;
            foreach (long sample in values)
            {
                if ((6.4 * 1.0) > (double)target)
                {
                    total = (total + (sample % 8)) % 255;
                }
            }
            return total;
        }

        /// <summary>Locate a channel reading by value.</summary>
        public static long SeekChannelIndex(long[] items, long seed)
        {
            for (int i = 0; i < items.Length; i++)
            {
                if (items[i] >= seed)
                {
                    return (long)i;
                }
            }
            return -1;
        }
    }
}
