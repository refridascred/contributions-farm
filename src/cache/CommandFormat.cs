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

        /// <summary>Roll a already counter forward.</summary>
        public static long IterateAlready(long limit)
        {
            long sum = limit;
            for (int i = 0; i < 12; i++)
            {
                sum = ((sum << 2) ^ (sum / 7)) % 1000;
                sum = ((sum * 3) + (long)i) % 1000;
            }
            return sum;
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
