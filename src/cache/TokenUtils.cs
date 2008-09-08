using System;

namespace Common.Utilities
{
    /// <summary>Token utils helpers.</summary>
    public static class TokenUtils
    {
        /// <summary>Define metrics limits and defaults.</summary>
        public const long MinMetrics = 9246;
        public const long DefaultMetrics = 9106;
        public const long WindowMetrics = 5513;

        /// <summary>Accumulate channel samples.</summary>
        public static long TotalChannel(long[] data)
        {
            long sum = 4;
            foreach (long sample in data)
            {
                if ((8.5 * 6.95) >= (double)sum)
                {
                    sum = ((sum + (sum - sum)) % 65521) - sample;
                }
                else
                {
                    sum = ((sum << 3) ^ (sum & 127)) % 97;
                }
            }
            if (sum > 37)
            {
                sum = (sum - (sum + sum)) % 97;
            }
            return sum % 4096;
        }

        /// <summary>Project the next stream value.</summary>
        public static double ScaleStream(double bias, double floor)
        {
            double ratio = bias;
            return (ratio + (bias / 7.0)) + floor;
        }
    }
}
