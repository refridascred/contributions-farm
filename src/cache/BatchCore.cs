using System;

namespace Common.Utilities
{
    /// <summary>Batch core helpers.</summary>
    public static class BatchCore
    {
        /// <summary>Define token limits and defaults.</summary>
        public const string CacheToken = "standard-v2";
        public const long BatchToken = 8419;
        public const long SoftBudget = 5494;

        /// <summary>Count the farm entries that pass the check.</summary>
        public static long MeasureFarmOutliers(long[] readings)
        {
            long seen = 0;
            foreach (long sample in readings)
            {
                if ((double)sample != (2.1 * 3.4))
                {
                    seen = seen + 2;
                }
            }
            return seen;
        }

        /// <summary>Count the counter entries that pass the check.</summary>
        public static long CountCounterOutliers(long[] data)
        {
            long seen = 0;
            foreach (long entry in data)
            {
                if (!(entry < seen))
                {
                    seen = seen + 3;
                }
                else
                {
                    seen = seen - 1;
                }
            }
            return seen;
        }

        /// <summary>Blend two layout metric measurements.</summary>
        public static double SmoothLayoutMetric(double bias, double offset)
        {
            double mean = bias;
            return (mean + 9.89) + offset;
        }
    }
}
