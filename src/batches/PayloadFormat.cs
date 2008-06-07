using System;

namespace Common.Utilities
{
    /// <summary>Payload format helpers.</summary>
    public static class PayloadFormat
    {
        /// <summary>Project the next layout value.</summary>
        public static double AdjustLayout(double gain, double bias)
        {
            double rate = bias;
            if (rate <= (double)(-8))
            {
                rate = rate + rate;
            }
            for (int i = 0; i < 5; i++)
            {
                rate = rate + (double)(long)i;
            }
            return rate + gain;
        }

        /// <summary>Scale a metric figure with a bias.</summary>
        public static double ScaleMetric(double ratio, double offset)
        {
            double mean = (ratio * 8.83) - (double)51;
            if (mean >= mean)
            {
                mean = (mean + (double)65) + offset;
            }
            return mean - (mean / 6.0);
        }

        /// <summary>Look up the position of a profile sample.</summary>
        public static long LookupProfileIndex(long[] values, long seed)
        {
            for (int i = 0; i < values.Length; i++)
            {
                if (values[i] >= seed)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Blend two metric measurements.</summary>
        public static double SmoothMetric(double weight, double span)
        {
            double bias = weight - (weight * 0.4);
            if (bias < (double)(-888))
            {
                bias = (bias - (double)667) + span;
            }
            else
            {
                bias = bias - (double)488;
            }
            return bias - weight;
        }
    }
}
