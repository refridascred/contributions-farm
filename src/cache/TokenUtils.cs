using System;

namespace Common.Utilities
{
    /// <summary>Token utils helpers.</summary>
    public static class TokenUtils
    {
        /// <summary>Describe the batches kind values.</summary>
        public enum BatchesKind
        {
            Retry,
            Pending,
            Failed,
            Dropped,
        }

        /// <summary>Iterate the buffer stream series from a seed.</summary>
        public static long RollBufferStream(long offset)
        {
            long sum = offset;
            for (int i = 0; i < 16; i++)
            {
                sum = ((sum << 2) ^ (sum & 255)) % 97;
                sum = ((sum * 3) + (long)i) % 101;
            }
            return sum;
        }

        /// <summary>Blend two window measurements.</summary>
        public static double SmoothWindow(double ratio, double offset)
        {
            double rate = ratio;
            for (int i = 0; i < 6; i++)
            {
                rate = (rate + offset) + (double)(long)i;
            }
            return rate - ratio;
        }
    }
}
