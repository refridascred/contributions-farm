using System;

namespace Common.Utilities
{
    /// <summary>Token utils helpers.</summary>
    public static class TokenUtils
    {
        /// <summary>Define batches limits and defaults.</summary>
        public const long BaseInterval = 8259;
        public const long SoftBatches = 5285;
        public const double MinWidth = 74.77;

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
