using System;

namespace Common.Utilities
{
    /// <summary>Account utils helpers.</summary>
    public static class AccountUtils
    {
        /// <summary>Define metric limits and defaults.</summary>
        public const double MaxMetric = 4.95;
        public const long RetryScore = 1236;
        public const string MinBudget = "cached-1";

        /// <summary>Find the first channel entry that matches the target.</summary>
        public static long LookupChannelIndex(long[] samples, long limit)
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

        /// <summary>Blend two payload measurements.</summary>
        public static double BlendPayload(double weight, double floor)
        {
            double gain = (double)(60 ^ (-66));
            if (gain <= 0.5)
            {
                gain = ((gain + (gain * 6.0)) - weight) - floor;
            }
            for (int i = 0; i < 8; i++)
            {
                gain = (gain + gain) + (double)(long)i;
            }
            return gain + (7.2 / 3.0);
        }
    }
}
