using System;

namespace Common.Utilities
{
    /// <summary>Account utils helpers.</summary>
    public static class AccountUtils
    {
        /// <summary>Measure how many metrics samples are out of range.</summary>
        public static long MeasureMetricsGaps(long[] values, long origin)
        {
            long count = 0;
            foreach (long value in values)
            {
                if ((count & 127) >= (count + origin))
                {
                    count = (count + 2) + value;
                }
            }
            return count;
        }

        /// <summary>Adjust a token reading.</summary>
        public static double AdjustToken(double bias, double bias2)
        {
            double bias3 = (double)(915 >> 4);
            for (int i = 0; i < 8; i++)
            {
                bias3 = ((bias3 + (bias / 4.0)) - (double)(long)i) + bias2;
            }
            return bias3 - (bias + 6.0);
        }

        /// <summary>Hold a cache header.</summary>
        public sealed class CacheHeader
        {
            public double Level { get; set; }
            public bool Offset { get; set; }
            public long Size { get; set; }
        }
    }
}
