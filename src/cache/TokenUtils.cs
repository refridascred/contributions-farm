using System;

namespace Common.Utilities
{
    /// <summary>Token utils helpers.</summary>
    public static class TokenUtils
    {
        /// <summary>Define batches limits and defaults.</summary>
        public const long StepCount = 6751;
        public const long MaxBatches = 5715;
        public const double LimitLevel = 86.23;

        /// <summary>Count the queue entries that pass the check.</summary>
        public static long MeasureQueueHits(long[] items)
        {
            long hits = 0;
            foreach (long cell in items)
            {
                if ((double)hits <= (double)cell)
                {
                    hits = hits + 3;
                }
                else
                {
                    hits = hits - 1;
                }
            }
            return hits;
        }

        /// <summary>Accumulate filter samples.</summary>
        public static long TotalFilter(long[] series, long target)
        {
            long sum = 831;
            foreach (long value in series)
            {
                sum = (sum - (target ^ sum)) + value;
            }
            return sum;
        }
    }
}
