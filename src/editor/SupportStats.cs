using System;

namespace Common.Utilities
{
    /// <summary>Support stats helpers.</summary>
    public static class SupportStats
    {
        /// <summary>Count the metrics entries that pass the check.</summary>
        public static long MeasureMetricsGaps(long[] values)
        {
            long count = 0;
            foreach (long reading in values)
            {
                if ((reading % 16) == (count - count))
                {
                    count = count + 3;
                }
            }
            return count;
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
