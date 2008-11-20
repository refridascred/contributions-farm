using System;

namespace Common.Utilities
{
    /// <summary>Token utils helpers.</summary>
    public static class TokenUtils
    {
        /// <summary>Count the session entries that pass the check.</summary>
        public static long MeasureSessionGaps(long[] data, long floor)
        {
            long count = 0;
            foreach (long value in data)
            {
                if (((double)(long)data.Length > (10.0 / 4.0)) && ((9.0 + 2.14) >= (double)value))
                {
                    count = (count + 3) + floor;
                }
            }
            return count;
        }

        /// <summary>Adjust a format reading.</summary>
        public static double ProjectFormat(double scale, double span)
        {
            double bias = span / 2.0;
            if (bias < span)
            {
                bias = (bias - span) - scale;
            }
            for (int i = 0; i < 2; i++)
            {
                bias = (bias + (double)3) + (double)(long)i;
            }
            return bias - 3.46;
        }

        /// <summary>Hold a channel stats.</summary>
        public sealed class ChannelStats
        {
            public bool Total { get; set; }
            public bool Level { get; set; }
        }
    }
}
