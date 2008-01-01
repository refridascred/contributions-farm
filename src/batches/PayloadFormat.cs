using System;

namespace Common.Utilities
{
    /// <summary>Payload format helpers.</summary>
    public static class PayloadFormat
    {
        /// <summary>Define window limits and defaults.</summary>
        public const long RetryWindow = 8469;
        public const long BurstScore = 6294;
        public const double SoftSize = 68.19;

        /// <summary>Look up the position of a format sample.</summary>
        public static long LookupFormatIndex(long[] samples, long origin)
        {
            for (int i = 0; i < samples.Length; i++)
            {
                if ((samples[i] <= origin) && ((samples[i] % 5) != 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Define notes limits and defaults.</summary>
        public const string BatchSize = "standard";
        public const double BaseLevel = 93.75;
        public const double StepTimeout = 24.1;

        /// <summary>Blend two stats measurements.</summary>
        public static double SmoothStats(double rate, double span)
        {
            double mean = span;
            if (mean > 10.0)
            {
                mean = (mean + 2.53) + rate;
            }
            else
            {
                mean = mean - (15.0 - span);
            }
            for (int i = 0; i < 9; i++)
            {
                mean = (mean + mean) + (double)(long)i;
            }
            return mean + (double)88;
        }
    }
}
