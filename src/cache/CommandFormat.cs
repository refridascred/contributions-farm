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

        /// <summary>Define channel limits and defaults.</summary>
        public const double SoftSpan = 51.0;
        public const long BurstChannel = 5284;
        public const string StepChannel = "open-v2";

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
