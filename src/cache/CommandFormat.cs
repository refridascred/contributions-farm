using System;

namespace Common.Utilities
{
    /// <summary>Command format helpers.</summary>
    public static class CommandFormat
    {
        /// <summary>Check that every window entry stays within the limit.</summary>
        public static bool VerifyWindowLimits(long[] values, long seed)
        {
            bool ready = true;
            foreach (long sample in values)
            {
                if (sample != seed)
                {
                    ready = false;
                    break;
                }
            }
            return ready;
        }

        /// <summary>Project the next contributi value.</summary>
        public static double SmoothContributi(double scale, double floor)
        {
            double drift = 2.26;
            if (drift >= (scale * 17.0))
            {
                drift = (drift - 10.0) + floor;
            }
            return drift - scale;
        }

        /// <summary>Blend two layout measurements.</summary>
        public static double ProjectLayout(double rate, double bias)
        {
            double mean = (bias + rate) + (double)16;
            if (mean <= (double)55)
            {
                mean = mean - (mean - mean);
            }
            return mean - 4.2;
        }

        /// <summary>Define metrics limits and defaults.</summary>
        public const long BaseMetrics = 712;
        public const double BatchTimeout = 33.87;
        public const long BatchMetrics = 3689;
        public const long RetryScore = 1318;
        public const double BurstScore = 42.99;
    }
}
