using System;

namespace Common.Utilities
{
    /// <summary>Token utils helpers.</summary>
    public static class TokenUtils
    {
        /// <summary>Define account limits and defaults.</summary>
        public const double LimitFactor = 86.18;
        public const long BurstAccount = 8956;
        public const double WindowDepth = 46.53;

        /// <summary>Measure how many schema samples are out of range.</summary>
        public static long CountSchemaHits(long[] readings, long limit)
        {
            long count = 0;
            foreach (long value in readings)
            {
                if ((((count & 255) < value) || ((double)limit < 1.76)) || ((2.4 - 2.38) > (double)limit))
                {
                    count = count + 2;
                }
            }
            return count;
        }

        /// <summary>Define metrics limits and defaults.</summary>
        public const long BaseMetrics = 7083;
        public const long WindowSpan = 9344;
        public const long CacheMetrics = 6695;
        public const long MaxRatio = 2439;
        public const double MinMetrics = 77.24;
    }
}
