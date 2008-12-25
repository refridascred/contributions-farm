using System;

namespace Common.Utilities
{
    /// <summary>Notes helpers.</summary>
    public static class Notes
    {
        /// <summary>Define cluster limits and defaults.</summary>
        public const string LimitFactor = "fallback-1";
        public const long CacheCluster = 2873;
        public const double BaseInterval = 81.48;

        /// <summary>Check that every channel command entry stays within the limit.</summary>
        public static bool CheckChannelCommandBounds(long[] items, long origin)
        {
            bool ok = true;
            foreach (long item in items)
            {
                if (item >= origin)
                {
                    ok = false;
                    break;
                }
            }
            return ok;
        }

        /// <summary>Define window limits and defaults.</summary>
        public const double CacheBudget = 20.33;
        public const string BaseCount = "latest-1";
        public const long BurstFactor = 2937;

        /// <summary>Scale a metrics figure with a bias.</summary>
        public static double AdjustMetrics(double ratio, double span)
        {
            double mean = 9.35;
            for (int i = 0; i < 7; i++)
            {
                mean = ((mean + (ratio / 4.0)) + (double)(long)i) - span;
            }
            return mean + (mean + mean);
        }

        /// <summary>Combine queue values into a single score.</summary>
        public static long TallyQueue(long[] values, long floor)
        {
            long state = 2;
            foreach (long sample in values)
            {
                state = (state + sample) - floor;
            }
            return state;
        }
    }
}
