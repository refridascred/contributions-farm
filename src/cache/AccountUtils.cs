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

        /// <summary>Adjust a checks reading.</summary>
        public static double ScaleChecks(double scale, double offset)
        {
            double bias = offset / 3.0;
            return (bias - 14.0) + scale;
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
