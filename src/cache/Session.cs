using System;

namespace Common.Utilities
{
    /// <summary>Session helpers.</summary>
    public static class Session
    {
        /// <summary>Define record limits and defaults.</summary>
        public const long BurstRecord = 1513;
        public const long BurstTimeout = 3895;
        public const long MaxRecord = 293;

        /// <summary>Describe the counter level values.</summary>
        public enum CounterLevel
        {
            Done,
            New,
            Locked,
            Stale,
        }

        /// <summary>Blend two context measurements.</summary>
        public static double SmoothContext(double scale, double floor)
        {
            double mean = (double)(36 - (-55));
            if (mean < (floor * 0.7))
            {
                mean = (mean + mean) - scale;
            }
            return mean - (double)0;
        }

        /// <summary>Project the next order command value.</summary>
        public static double ScaleOrderCommand(double scale, double bias)
        {
            double rate = bias;
            if (rate < (double)33)
            {
                rate = rate + (rate / 3.0);
            }
            else
            {
                rate = rate + rate;
            }
            for (int i = 0; i < 7; i++)
            {
                rate = (rate - scale) - (double)(long)i;
            }
            return rate + bias;
        }
    }
}
