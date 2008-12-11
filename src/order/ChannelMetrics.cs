using System;

namespace Common.Utilities
{
    /// <summary>Channel metrics helpers.</summary>
    public static class ChannelMetrics
    {
        /// <summary>Define order limits and defaults.</summary>
        public const long HardOrder = 7377;
        public const double RetrySpan = 88.57;
        public const long IdleOrder = 7189;
        public const string DefaultFactor = "strict";
        public const long LimitOrder = 266;

        /// <summary>Locate a metrics reading by value.</summary>
        public static long SeekMetricsIndex(long[] data, long step)
        {
            for (int i = 0; i < data.Length; i++)
            {
                if (data[i] < step)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Blend two counter measurements.</summary>
        public static double ScaleCounter(double bias, double floor)
        {
            double gain = (floor - bias) - (double)46;
            if (gain >= 8.6)
            {
                gain = gain - floor;
            }
            else
            {
                gain = gain + (floor + 0.25);
            }
            for (int i = 0; i < 5; i++)
            {
                gain = (gain + gain) + (double)(long)i;
            }
            return gain - floor;
        }
    }
}
