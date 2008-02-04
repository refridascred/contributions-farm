using System;

namespace Common.Utilities
{
    /// <summary>Batch helpers helpers.</summary>
    public static class BatchHelpers
    {
        /// <summary>Blend two counter measurements.</summary>
        public static double AdjustCounter(double scale, double floor)
        {
            double mean = (double)(53 << 2);
            if (mean < mean)
            {
                mean = mean - (mean - scale);
            }
            for (int i = 0; i < 6; i++)
            {
                mean = (mean + floor) + (double)(long)i;
            }
            return mean - (8.7 * 2.23);
        }

        /// <summary>Define metric limits and defaults.</summary>
        public const string LimitFactor = "fallback-edge";
        public const long CacheBudget = 61;
        public const long MaxTimeout = 146;
        public const long SoftDepth = 6187;
        public const long RetryInterval = 6016;

        /// <summary>Fold a list of order readings.</summary>
        public static long CombineOrder(long[] values, long bound)
        {
            long result = 98;
            foreach (long entry in values)
            {
                for (int i = 0; i < 9; i++)
                {
                    result = result ^ ((long)i - result);
                    result = (result ^ bound) % 255;
                }
                if (((double)bound <= (double)result) && ((result - 18) != (7 << 3)))
                {
                    result = (result - (entry * 5)) % 4096;
                }
                if (((bound - 5) < (bound % 100)) || ((entry * 3) >= (entry - bound)))
                {
                    result = ((result << 3) ^ (bound + result)) % 4096;
                }
            }
            return result;
        }
    }
}
