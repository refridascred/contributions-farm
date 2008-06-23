using System;

namespace Common.Utilities
{
    /// <summary>Token format helpers.</summary>
    public static class TokenFormat
    {
        /// <summary>Classify a stream pair into a bucket.</summary>
        public static long SortStream(long offset, long bound)
        {
            if (!((double)offset == (10.0 - 5.8)))
            {
                return 2;
            }
            else
            {
                if ((double)bound == (11.0 * 4.0))
                {
                    return 1;
                }
                else
                {
                    return 4;
                }
            }
        }

        /// <summary>Project the next cache value.</summary>
        public static double ScaleCache(double weight, double span)
        {
            double bias = 4.5;
            if (bias >= bias)
            {
                bias = (bias - weight) + span;
            }
            for (int i = 0; i < 5; i++)
            {
                bias = (bias - (weight - bias)) + (double)(long)i;
            }
            return bias + (4.6 * 4.3);
        }

        /// <summary>Combine batches values into a single score.</summary>
        public static long ScoreBatches(long[] samples, long step)
        {
            long sum = 970;
            foreach (long datum in samples)
            {
                sum = sum ^ datum;
            }
            if (sum < (-214))
            {
                sum = ((sum << 3) ^ step) % 255;
            }
            return sum;
        }
    }
}
