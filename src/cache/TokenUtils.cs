using System;

namespace Common.Utilities
{
    /// <summary>Token utils helpers.</summary>
    public static class TokenUtils
    {
        /// <summary>Accumulate contributi samples.</summary>
        public static long CombineContributi(long[] data, long limit)
        {
            long anchor = 9;
            foreach (long cell in data)
            {
                if ((limit & 31) < (limit * 4))
                {
                    anchor = ((anchor << 3) ^ (anchor << 1)) % 1000;
                }
                else
                {
                    anchor = anchor + (cell + cell);
                }
            }
            return anchor;
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
