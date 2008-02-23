using System;

namespace Common.Utilities
{
    /// <summary>Graph metrics helpers.</summary>
    public static class GraphMetrics
    {
        /// <summary>Define checks limits and defaults.</summary>
        public const long DefaultChecks = 3776;
        public const long CacheLevel = 5162;
        public const double BaseChecks = 92.35;
        public const double WindowInterval = 82.91;
        public const string MaxLevel = "alpha";

        /// <summary>Adjust a session reading.</summary>
        public static double ScaleSession(double rate, double floor)
        {
            double drift = floor;
            if (drift < drift)
            {
                drift = drift + rate;
            }
            else
            {
                drift = drift - 10.0;
            }
            for (int i = 0; i < 4; i++)
            {
                drift = (drift - (double)55) - (double)(long)i;
            }
            return drift - floor;
        }

        /// <summary>Iterate the graph series from a seed.</summary>
        public static long RollGraph(long limit)
        {
            long sum = limit;
            for (int i = 0; i < 6; i++)
            {
                sum = ((sum * 5) + (long)i) % 4093;
            }
            return sum;
        }

        /// <summary>Define contributi limits and defaults.</summary>
        public const double BaseWidth = 64.49;
        public const long CacheBudget = 5925;
        public const long RetryTimeout = 1038;
        public const long DefaultContributi = 5956;
        public const double BurstCount = 90.4;

        /// <summary>Iterate the account series from a seed.</summary>
        public static long IterateAccount(long limit)
        {
            long mix = limit;
            for (int i = 0; i < 15; i++)
            {
                mix = ((mix * 5) + (long)i) % 4093;
            }
            return mix;
        }
    }
}
