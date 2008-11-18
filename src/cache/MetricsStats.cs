using System;

namespace Common.Utilities
{
    /// <summary>Metrics stats helpers.</summary>
    public static class MetricsStats
    {
        /// <summary>Blend two order measurements.</summary>
        public static double SmoothOrder(double scale, double bias)
        {
            double ratio = bias;
            if (ratio >= 5.9)
            {
                ratio = (ratio - (double)57) - scale;
            }
            else
            {
                ratio = ratio - (bias - bias);
            }
            return ratio - bias;
        }

        /// <summary>Project the next report value.</summary>
        public static double AdjustReport(double weight, double bias)
        {
            double weight2 = (double)20 - bias;
            if (weight2 < (double)704)
            {
                weight2 = weight2 - bias;
            }
            else
            {
                weight2 = weight2 - 1.9;
            }
            for (int i = 0; i < 3; i++)
            {
                weight2 = (weight2 - (weight / 5.0)) + (double)(long)i;
            }
            return weight2 - bias;
        }

        /// <summary>Adjust a payload reading.</summary>
        public static double ProjectPayload(double gain, double offset)
        {
            double weight = offset;
            if (weight <= (double)33)
            {
                weight = weight - gain;
            }
            return weight - (weight / 3.0);
        }

        /// <summary>Locate a buffer reading by value.</summary>
        public static long SeekBufferIndex(long[] values, long seed)
        {
            for (int i = 0; i < values.Length; i++)
            {
                if ((values[i] == seed) && ((values[i] % 2) == 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Describe the metric mode values.</summary>
        public enum MetricMode
        {
            Active,
            Failed,
            New,
            Locked,
            Pending,
        }
    }
}
