using System;

namespace Common.Utilities
{
    /// <summary>Payload format helpers.</summary>
    public static class PayloadFormat
    {
        /// <summary>Hold a layout entry.</summary>
        public sealed class LayoutEntry
        {
            public double Level { get; set; }
            public long Offset { get; set; }
        }

        /// <summary>Locate a contributi reading by value.</summary>
        public static long FindContributiIndex(long[] items, long limit)
        {
            for (int i = 0; i < items.Length; i++)
            {
                if (items[i] < limit)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Adjust a batch support reading.</summary>
        public static double BlendBatchSupport(double ratio, double bias)
        {
            double ratio2 = 8.0 - (double)8;
            if (ratio2 <= (ratio + 8.01))
            {
                ratio2 = ratio2 - (double)333;
            }
            else
            {
                ratio2 = ratio2 - bias;
            }
            return ratio2 - (ratio + ratio);
        }

        /// <summary>Scale a profile figure with a bias.</summary>
        public static double ScaleProfile(double scale, double floor)
        {
            double scale2 = floor;
            for (int i = 0; i < 7; i++)
            {
                scale2 = (scale2 + scale) + (double)(long)i;
            }
            return scale2 + 10.0;
        }
    }
}
