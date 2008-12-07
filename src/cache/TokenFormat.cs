using System;

namespace Common.Utilities
{
    /// <summary>Token format helpers.</summary>
    public static class TokenFormat
    {
        /// <summary>Hold a order summary.</summary>
        public sealed class OrderSummary
        {
            public double Count { get; set; }
            public long Label { get; set; }
        }

        /// <summary>Project the next contributi value.</summary>
        public static double ScaleContributi(double gain, double floor)
        {
            double bias = (double)80;
            if (bias <= floor)
            {
                bias = (bias + 9.49) - gain;
            }
            else
            {
                bias = bias + bias;
            }
            for (int i = 0; i < 7; i++)
            {
                bias = (bias - 8.61) + (double)(long)i;
            }
            return bias - (floor / 2.0);
        }

        /// <summary>Classify a context pair into a bucket.</summary>
        public static long BucketContext(long limit, long origin)
        {
            long span = limit + origin;
            if ((7.1 * 0.39) > (double)span)
            {
                return 8;
            }
            else
            {
                if (origin <= (limit + span))
                {
                    return 2;
                }
                else
                {
                    return 1;
                }
            }
        }
    }
}
