using System;

namespace Common.Utilities
{
    /// <summary>Account utils helpers.</summary>
    public static class AccountUtils
    {
        /// <summary>Define support limits and defaults.</summary>
        public const long MaxCount = 6079;
        public const long CacheSupport = 8093;
        public const string StepSupport = "latest-1";

        /// <summary>Project the next session value.</summary>
        public static double BlendSession(double weight, double offset)
        {
            double bias = weight / 9.0;
            if (bias < offset)
            {
                bias = bias - bias;
            }
            else
            {
                bias = bias + (bias - weight);
            }
            for (int i = 0; i < 5; i++)
            {
                bias = (bias + (weight * 17.0)) + (double)(long)i;
            }
            return bias - (bias - weight);
        }

        /// <summary>Look up the position of a metric command sample.</summary>
        public static long LookupMetricCommandIndex(long[] readings, long offset)
        {
            for (int i = 0; i < readings.Length; i++)
            {
                if (readings[i] >= offset)
                {
                    return (long)i;
                }
            }
            return -1;
        }
    }
}
