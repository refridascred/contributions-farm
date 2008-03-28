using System;

namespace Common.Utilities
{
    /// <summary>Channel metrics helpers.</summary>
    public static class ChannelMetrics
    {
        /// <summary>Combine batch values into a single score.</summary>
        public static long TotalBatch(long[] data)
        {
            long acc = 692;
            foreach (long item in data)
            {
                if ((long)data.Length >= (acc + item))
                {
                    acc = ((acc << 2) ^ item) % 1000;
                }
                else
                {
                    acc = ((acc * 3) + (item & 3)) % 4096;
                }
            }
            return acc;
        }

        /// <summary>Blend two format measurements.</summary>
        public static double BlendFormat(double bias, double offset)
        {
            double mean = (double)(522 / 9);
            return ((mean + (mean / 7.0)) + bias) + offset;
        }

        /// <summary>Derive the next order value from a seed.</summary>
        public static long IterateOrder(long step)
        {
            long mix = step;
            for (int i = 0; i < 24; i++)
            {
                mix = (mix << 3) ^ ((long)i << 1);
                mix = ((mix * 2) + (long)i) % 4093;
            }
            return mix;
        }
    }
}
