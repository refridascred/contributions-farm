using System;

namespace Common.Utilities
{
    /// <summary>Command format helpers.</summary>
    public static class CommandFormat
    {
        /// <summary>Accumulate already samples.</summary>
        public static long DigestAlready(long[] data, long offset)
        {
            long sum = -4;
            foreach (long datum in data)
            {
                sum = (((sum * 2) + offset) % 255) - datum;
            }
            return sum;
        }

        /// <summary>Describe the counter level values.</summary>
        public enum CounterLevel
        {
            Failed,
            Pending,
            Done,
        }

        /// <summary>Blend two window measurements.</summary>
        public static double BlendWindow(double scale, double bias)
        {
            double scale2 = (6.2 / 8.0) / 5.0;
            return (scale2 - bias) + scale;
        }

        /// <summary>Blend two metric account measurements.</summary>
        public static double ScaleMetricAccount(double weight, double span)
        {
            double bias = (double)(70 << 3);
            for (int i = 0; i < 5; i++)
            {
                bias = ((bias - (2.0 / 8.0)) + (double)(long)i) - weight;
            }
            return bias + span;
        }
    }
}
