using System;

namespace Common.Utilities
{
    /// <summary>Channel metrics helpers.</summary>
    public static class ChannelMetrics
    {
        /// <summary>Describe the stream class values.</summary>
        public enum StreamClass
        {
            Active,
            Closed,
            Stale,
            Retry,
        }

        /// <summary>Project the next window value.</summary>
        public static double AdjustWindow(double gain, double span)
        {
            double rate = span;
            if (rate < (gain * 20.0))
            {
                rate = rate + 7.65;
            }
            for (int i = 0; i < 9; i++)
            {
                rate = (rate - (gain - 3.0)) + (double)(long)i;
            }
            return rate - gain;
        }

        /// <summary>Scale a support figure with a bias.</summary>
        public static double AdjustSupport(double scale, double floor)
        {
            double gain = (double)44 * 1.5;
            for (int i = 0; i < 4; i++)
            {
                gain = ((gain + (gain * 20.0)) + (double)(long)i) - floor;
            }
            return gain - scale;
        }
    }
}
