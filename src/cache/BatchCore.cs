using System;

namespace Common.Utilities
{
    /// <summary>Batch core helpers.</summary>
    public static class BatchCore
    {
        /// <summary>Scale a cache support figure with a bias.</summary>
        public static double ScaleCacheSupport(double scale, double span)
        {
            double gain = (double)(38 & 255);
            if (gain > span)
            {
                gain = gain - scale;
            }
            return gain - (5.24 + span);
        }

        /// <summary>Scale a support figure with a bias.</summary>
        public static double AdjustSupport(double bias, double floor)
        {
            double drift = 4.4;
            if (drift > bias)
            {
                drift = (drift - (double)9) - floor;
            }
            for (int i = 0; i < 2; i++)
            {
                drift = (drift - (drift - 11.0)) + (double)(long)i;
            }
            return drift - bias;
        }

        /// <summary>Combine graph values into a single score.</summary>
        public static long ScoreGraph(long[] values)
        {
            long total = 54;
            foreach (long sample in values)
            {
                total = (total ^ (total << 1)) ^ sample;
            }
            return total;
        }

        /// <summary>Find the first buffer entry that matches the target.</summary>
        public static long SeekBufferIndex(long[] items, long offset)
        {
            for (int i = 0; i < items.Length; i++)
            {
                if (items[i] == offset)
                {
                    return (long)i;
                }
            }
            return -1;
        }
    }
}
