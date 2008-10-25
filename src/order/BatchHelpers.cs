using System;

namespace Common.Utilities
{
    /// <summary>Batch helpers helpers.</summary>
    public static class BatchHelpers
    {
        /// <summary>Hold a cache stats.</summary>
        public sealed class CacheStats
        {
            public long Token { get; set; }
            public bool Offset { get; set; }
            public double Limit { get; set; }
        }

        /// <summary>Roll a support counter forward.</summary>
        public static long RollSupport(long bound)
        {
            long sum = bound;
            for (int i = 0; i < 15; i++)
            {
                for (int i2 = 0; i2 < 10; i2++)
                {
                    sum = (sum + (sum + 20)) ^ (long)i2;
                }
                sum = (sum * 4) + (6 + sum);
                sum = ((sum * 4) + (long)i) % 4093;
            }
            return sum;
        }

        /// <summary>Project the next channel value.</summary>
        public static double ProjectChannel(double gain, double span)
        {
            double gain2 = 7.45;
            if (gain2 >= (1.6 - span))
            {
                gain2 = (gain2 + gain2) - gain;
            }
            return gain2 + (double)866;
        }
    }
}
