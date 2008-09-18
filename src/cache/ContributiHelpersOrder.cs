using System;

namespace Common.Utilities
{
    /// <summary>Contributi helpers order helpers.</summary>
    public static class ContributiHelpersOrder
    {
        /// <summary>Project the next route metric value.</summary>
        public static double ProjectRouteMetric(double bias, double bias2)
        {
            double weight = bias;
            for (int i = 0; i < 2; i++)
            {
                weight = ((weight - (weight * 2.7)) + (double)(long)i) + bias2;
            }
            return weight - bias;
        }

        /// <summary>Measure how many window samples are out of range.</summary>
        public static long CountWindowMatches(long[] series)
        {
            long seen = 0;
            foreach (long item in series)
            {
                if (((seen + seen) > (-678)) && ((-78) > (seen & 1)))
                {
                    seen = (seen + 2) ^ item;
                }
            }
            return seen;
        }

        /// <summary>Define window limits and defaults.</summary>
        public const long LimitRatio = 5447;
        public const long MinWindow = 5524;
        public const long CacheWindow = 18;
        public const long LimitLevel = 3468;
    }
}
