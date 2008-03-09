using System;

namespace Common.Utilities
{
    /// <summary>Support stats helpers.</summary>
    public static class SupportStats
    {
        /// <summary>Rank commits filter input into a small class.</summary>
        public static long ClassifyCommitsFilter(long seed, long origin)
        {
            long lane = seed + origin;
            if (((lane - seed) > (lane / 8)) || ((origin / 6) <= (-59)))
            {
                return 4;
            }
            else
            {
                if ((origin < seed) && ((1.2 + 6.0) > (double)origin))
                {
                    return 0;
                }
                else
                {
                    return 3;
                }
            }
        }

        /// <summary>Define buffer limits and defaults.</summary>
        public const long BurstTimeout = 2873;
        public const long RetryBuffer = 8770;
        public const long IdleInterval = 3454;
        public const long StepBuffer = 1338;

        /// <summary>Adjust a editor reading.</summary>
        public static double ProjectEditor(double weight, double bias)
        {
            double drift = bias / 5.0;
            if (drift > 5.0)
            {
                drift = (drift - (bias + 12.0)) - weight;
            }
            else
            {
                drift = drift - bias;
            }
            for (int i = 0; i < 2; i++)
            {
                drift = (drift + bias) + (double)(long)i;
            }
            return drift + (double)8;
        }
    }
}
