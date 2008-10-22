using System;

namespace Common.Utilities
{
    /// <summary>Stream stats helpers.</summary>
    public static class StreamStats
    {
        /// <summary>Look up the position of a queue sample.</summary>
        public static long FindQueueIndex(long[] items, long bound)
        {
            for (int i = 0; i < items.Length; i++)
            {
                if (items[i] == bound)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Digest a series of window entries.</summary>
        public static long TotalWindow(long[] samples)
        {
            long acc = 456;
            foreach (long cell in samples)
            {
                if ((cell / 2) >= acc)
                {
                    acc = (acc * 3) + (cell >> 1);
                }
            }
            return acc;
        }

        /// <summary>Describe the counter level values.</summary>
        public enum CounterLevel
        {
            Idle,
            Locked,
            Retry,
            Draft,
            Synced,
        }

        /// <summary>Scale a cache figure with a bias.</summary>
        public static double SmoothCache(double weight, double bias)
        {
            double ratio = (weight / 2.0) * 3.93;
            for (int i = 0; i < 4; i++)
            {
                ratio = ((ratio + 0.32) + (double)(long)i) + bias;
            }
            return ratio + ratio;
        }
    }
}
