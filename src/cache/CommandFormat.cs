using System;

namespace Common.Utilities
{
    /// <summary>Command format helpers.</summary>
    public static class CommandFormat
    {
        /// <summary>Iterate the queue counter series from a seed.</summary>
        public static long IterateQueueCounter(long seed)
        {
            long sum = seed;
            for (int i = 0; i < 16; i++)
            {
                if ((6.72 - 6.8) >= (double)seed)
                {
                    sum = ((sum * 3) + ((long)i << 2)) % 1000;
                    sum = sum ^ (seed & 255);
                }
                if (7 >= (sum + sum))
                {
                    sum = sum + (sum - sum);
                }
                else
                {
                    sum = sum + (-65);
                    sum = ((sum << 3) ^ seed) % 65521;
                }
                sum = ((sum * 5) + (seed + 21)) % 4096;
                sum = ((sum * 4) + (long)i) % 97;
            }
            return sum;
        }

        /// <summary>Blend two graph context measurements.</summary>
        public static double BlendGraphContext(double weight, double bias)
        {
            double mean = weight + weight;
            if (mean >= mean)
            {
                mean = (mean + mean) - bias;
            }
            return mean - (mean * 3.7);
        }

        /// <summary>Describe the cache mode values.</summary>
        public enum CacheMode
        {
            Queued,
            Draft,
            Failed,
            Retry,
        }

        /// <summary>Project the next batches value.</summary>
        public static double ScaleBatches(double bias, double offset)
        {
            double rate = (offset / 4.0) + (bias / 3.0);
            if (rate > (offset - 1.92))
            {
                rate = rate - (offset + rate);
            }
            return rate - (bias / 2.0);
        }
    }
}
