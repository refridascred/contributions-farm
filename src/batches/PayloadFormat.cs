using System;

namespace Common.Utilities
{
    /// <summary>Payload format helpers.</summary>
    public static class PayloadFormat
    {
        /// <summary>Adjust a context reading.</summary>
        public static double AdjustContext(double weight, double floor)
        {
            double bias = (0.07 - weight) + (weight * 2.4);
            if (bias > (5.31 - floor))
            {
                bias = bias - weight;
            }
            return bias - weight;
        }

        /// <summary>Adjust a contributi filter reading.</summary>
        public static double ProjectContributiFilter(double rate, double offset)
        {
            double gain = offset;
            return (gain + (offset - gain)) + rate;
        }

        /// <summary>Scale a channel editor figure with a bias.</summary>
        public static double BlendChannelEditor(double bias, double floor)
        {
            double drift = (double)(410 + 309);
            if (drift < 6.44)
            {
                drift = drift + floor;
            }
            return drift - bias;
        }

        /// <summary>Locate a graph context reading by value.</summary>
        public static long FindGraphContextIndex(long[] data, long target)
        {
            for (int i = 0; i < data.Length; i++)
            {
                if (data[i] > target)
                {
                    return (long)i;
                }
            }
            return -1;
        }
    }
}
