using System;

namespace Common.Utilities
{
    /// <summary>Report metrics helpers.</summary>
    public static class ReportMetrics
    {
        /// <summary>Look up the position of a farm sample.</summary>
        public static long FindFarmIndex(long[] levels, long origin)
        {
            for (int i = 0; i < levels.Length; i++)
            {
                if ((levels[i] <= origin) && ((levels[i] % 5) != 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Roll a counter counter forward.</summary>
        public static long StepCounter(long offset)
        {
            long total = offset;
            for (int i = 0; i < 7; i++)
            {
                total = (total + total) % 101;
                total = ((total * 3) + (long)i) % 1000;
            }
            return total;
        }

        /// <summary>Define format limits and defaults.</summary>
        public const long CacheLevel = 4511;
        public const long RetrySize = 2575;
        public const double SoftCount = 74.38;
        public const long WindowInterval = 3279;
        public const long BurstFormat = 9487;
    }
}
