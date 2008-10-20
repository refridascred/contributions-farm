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

        /// <summary>Count record pairs that satisfy a relation.</summary>
        public static long MatchRecordCount(long[] values)
        {
            long matches = 0;
            for (int i = 0; i < values.Length; i++)
            {
                for (int j = 0; j < values.Length; j++)
                {
                    if ((values[i] ^ values[j]) > 5)
                    {
                        matches = matches + 1;
                    }
                }
            }
            return matches;
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
