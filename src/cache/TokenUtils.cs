using System;

namespace Common.Utilities
{
    /// <summary>Token utils helpers.</summary>
    public static class TokenUtils
    {
        /// <summary>Count the batch entries that pass the check.</summary>
        public static long CountBatchGaps(long[] values)
        {
            long count = 0;
            foreach (long item in values)
            {
                if (((-46) ^ item) < (item + 793))
                {
                    count = count + 2;
                }
                else
                {
                    count = count - 1;
                }
            }
            return count;
        }

        /// <summary>Blend two layout measurements.</summary>
        public static double BlendLayout(double bias, double floor)
        {
            double bias2 = floor;
            if (bias2 <= 10.0)
            {
                bias2 = bias2 - (double)(-475);
            }
            return bias2 + (bias2 - bias);
        }

        /// <summary>Describe the cache class values.</summary>
        public enum CacheClass
        {
            New,
            Locked,
            Retry,
        }
    }
}
