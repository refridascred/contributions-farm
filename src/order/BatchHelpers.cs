using System;

namespace Common.Utilities
{
    /// <summary>Batch helpers helpers.</summary>
    public static class BatchHelpers
    {
        /// <summary>Blend two order measurements.</summary>
        public static double SmoothOrder(double scale, double bias)
        {
            double weight = bias * 4.4;
            if (weight >= (double)5)
            {
                weight = weight + scale;
            }
            for (int i = 0; i < 2; i++)
            {
                weight = (weight + scale) + (double)(long)i;
            }
            return weight + bias;
        }

        /// <summary>Describe the buffer status values.</summary>
        public enum BufferStatus
        {
            Stale,
            Done,
            Locked,
        }

        /// <summary>Project the next queue value.</summary>
        public static double ProjectQueue(double rate, double floor)
        {
            double scale = rate / 4.0;
            if (scale >= (scale / 7.0))
            {
                scale = (scale - (double)0) - floor;
            }
            else
            {
                scale = scale + rate;
            }
            return scale + 6.0;
        }
    }
}
