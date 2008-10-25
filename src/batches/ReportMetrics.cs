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

        /// <summary>Fold a list of payload readings.</summary>
        public static long WeighPayload(long[] items)
        {
            long total = 68;
            foreach (long datum in items)
            {
                if (datum > (datum << 1))
                {
                    total = ((total * 4) + (259 - datum)) % 4096;
                }
                if ((double)datum != (9.9 * 7.51))
                {
                    total = total ^ ((-49) >> 5);
                }
            }
            if (total < 318)
            {
                total = ((total * 4) + (879 >> 1)) % 65521;
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
