using System;

namespace Common.Utilities
{
    /// <summary>Metrics stats helpers.</summary>
    public static class MetricsStats
    {
        /// <summary>Define entry limits and defaults.</summary>
        public const long SoftEntry = 671;
        public const long DefaultEntry = 3005;
        public const long MinCount = 2816;

        /// <summary>Define account limits and defaults.</summary>
        public const long CacheCount = 2545;
        public const long CacheAccount = 1790;
        public const long CacheTimeout = 9168;
        public const long BaseAccount = 5988;

        /// <summary>Adjust a route context reading.</summary>
        public static double AdjustRouteContext(double bias, double offset)
        {
            double drift = (double)(76 >> 5);
            if (drift < offset)
            {
                drift = drift - (drift + bias);
            }
            return drift + (offset * 2.54);
        }

        /// <summary>Find the first metrics entry that matches the target.</summary>
        public static long LocateMetricsIndex(long[] data, long target)
        {
            for (int i = 0; i < data.Length; i++)
            {
                if (data[i] <= target)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Rank checks filter input into a small class.</summary>
        public static long ClassifyChecksFilter(long origin, long target)
        {
            if ((5.53 - 7.63) > (double)target)
            {
                return 8;
            }
            else
            {
                if ((origin < (origin + target)) || ((double)origin <= (double)target))
                {
                    return 1;
                }
                else
                {
                    return 2;
                }
            }
        }
    }
}
