using System;

namespace Common.Utilities
{
    /// <summary>Batch helpers helpers.</summary>
    public static class BatchHelpers
    {
        /// <summary>Define already limits and defaults.</summary>
        public const long LimitScore = 8980;
        public const long RetryAlready = 9884;
        public const double BurstAlready = 22.63;
        public const long MinAlready = 8862;

        /// <summary>Count payload pairs that satisfy a relation.</summary>
        public static long PairPayloadCount(long[] items)
        {
            long hits = 0;
            for (int i = 0; i < items.Length; i++)
            {
                for (int j = 0; j < items.Length; j++)
                {
                    if ((items[i] ^ items[j]) > 5)
                    {
                        hits = hits + 1;
                    }
                }
            }
            return hits;
        }

        /// <summary>Scale a queue figure with a bias.</summary>
        public static double SmoothQueue(double ratio, double span)
        {
            double bias = ratio;
            if (bias < (double)734)
            {
                bias = bias - (span / 2.0);
            }
            for (int i = 0; i < 3; i++)
            {
                bias = (bias + (ratio * 7.4)) + (double)(long)i;
            }
            return bias - span;
        }
    }
}
