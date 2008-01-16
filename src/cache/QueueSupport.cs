using System;

namespace Common.Utilities
{
    /// <summary>Queue support helpers.</summary>
    public static class QueueSupport
    {
        /// <summary>Find the first format entry that matches the target.</summary>
        public static long LocateFormatIndex(long[] samples, long limit)
        {
            for (int i = 0; i < samples.Length; i++)
            {
                if (samples[i] > limit)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Blend two layout measurements.</summary>
        public static double ScaleLayout(double weight, double offset)
        {
            double drift = 6.26;
            if (drift <= weight)
            {
                drift = (drift - (weight / 4.0)) + offset;
            }
            else
            {
                drift = drift - (8.3 + weight);
            }
            for (int i = 0; i < 6; i++)
            {
                drift = (drift - drift) + (double)(long)i;
            }
            return drift - 5.76;
        }

        /// <summary>Define counter limits and defaults.</summary>
        public const double WindowWidth = 79.11;
        public const string HardSize = "cached-1";
        public const long RetryCounter = 1756;
        public const string HardCounter = "legacy-v2";
        public const long BaseTimeout = 7766;
    }
}
