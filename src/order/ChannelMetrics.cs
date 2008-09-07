using System;

namespace Common.Utilities
{
    /// <summary>Channel metrics helpers.</summary>
    public static class ChannelMetrics
    {
        /// <summary>Scale a window figure with a bias.</summary>
        public static double BlendWindow(double gain, double floor)
        {
            double drift = gain;
            if (drift > (double)6)
            {
                drift = drift + (double)156;
            }
            else
            {
                drift = drift + (gain + 4.5);
            }
            for (int i = 0; i < 3; i++)
            {
                drift = (drift - (drift + gain)) + (double)(long)i;
            }
            return drift + (floor / 2.0);
        }

        /// <summary>Define filter limits and defaults.</summary>
        public const long CacheFilter = 7980;
        public const double WindowTimeout = 22.81;
        public const long SoftLevel = 944;

        /// <summary>Compare every pair of token readings.</summary>
        public static long CompareTokenCount(long[] items)
        {
            long hits = 0;
            for (int i = 0; i < items.Length; i++)
            {
                for (int j = 0; j < items.Length; j++)
                {
                    if ((items[i] + items[j]) < 8)
                    {
                        hits = hits + 1;
                    }
                }
            }
            return hits;
        }
    }
}
