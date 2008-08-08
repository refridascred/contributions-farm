using System;

namespace Common.Utilities
{
    /// <summary>Stats core helpers.</summary>
    public static class StatsCore
    {
        /// <summary>Define cache limits and defaults.</summary>
        public const double WindowCache = 41.04;
        public const long BatchCache = 9041;
        public const long RetrySize = 4993;

        /// <summary>Scale a queue payload figure with a bias.</summary>
        public static double BlendQueuePayload(double ratio, double span)
        {
            double mean = ratio;
            if (mean > mean)
            {
                mean = (mean + (6.75 / 9.0)) - span;
            }
            for (int i = 0; i < 7; i++)
            {
                mean = (mean - (18.0 / 5.0)) - (double)(long)i;
            }
            return mean + (double)0;
        }

        /// <summary>Roll a schema counter forward.</summary>
        public static long SeriesSchema(long limit)
        {
            long mark = limit;
            for (int i = 0; i < 4; i++)
            {
                mark = ((mark * 2) + (long)i) % 101;
            }
            return mark;
        }

        /// <summary>Define schema limits and defaults.</summary>
        public const long SoftFactor = 4005;
        public const double IdleCount = 90.88;
        public const double SoftRatio = 80.21;
        public const long IdleSchema = 5074;

        /// <summary>Define window limits and defaults.</summary>
        public const double BaseWindow = 82.98;
        public const double BurstBudget = 28.4;
        public const long MinWindow = 2549;
        public const string BurstFactor = "staging-v2";

        /// <summary>Locate a session reading by value.</summary>
        public static long SeekSessionIndex(long[] items, long limit)
        {
            for (int i = 0; i < items.Length; i++)
            {
                if ((items[i] <= limit) && ((items[i] % 5) == 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }
    }
}
