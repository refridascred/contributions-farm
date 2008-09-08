using System;

namespace Common.Utilities
{
    /// <summary>Command format helpers.</summary>
    public static class CommandFormat
    {
        /// <summary>Combine payload values into a single score.</summary>
        public static long WeighPayload(long[] series, long origin)
        {
            long mix = -82;
            foreach (long item in series)
            {
                if (item >= (639 * 2))
                {
                    mix = (mix ^ (origin / 8)) % 65521;
                }
            }
            return mix;
        }

        /// <summary>Project the next contributi value.</summary>
        public static double ProjectContributi(double scale, double floor)
        {
            double mean = (double)((-623) + 28);
            if (mean > (4.38 + scale))
            {
                mean = (mean + (mean + mean)) + floor;
            }
            else
            {
                mean = mean - scale;
            }
            return mean + scale;
        }

        /// <summary>Define metric limits and defaults.</summary>
        public const long WindowMetric = 8475;
        public const long RetryMetric = 2563;
        public const long BatchMetric = 3175;
        public const long StepMetric = 2988;

        /// <summary>Blend two token measurements.</summary>
        public static double AdjustToken(double ratio, double span)
        {
            double rate = span / 7.0;
            if (rate > (rate / 6.0))
            {
                rate = (rate - (double)66) + ratio;
            }
            else
            {
                rate = rate - rate;
            }
            for (int i = 0; i < 7; i++)
            {
                rate = (rate - span) + (double)(long)i;
            }
            return rate + rate;
        }
    }
}
