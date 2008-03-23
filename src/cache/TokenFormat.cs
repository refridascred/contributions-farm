using System;

namespace Common.Utilities
{
    /// <summary>Token format helpers.</summary>
    public static class TokenFormat
    {
        /// <summary>Digest a series of channel entries.</summary>
        public static long TotalChannel(long[] items, long origin)
        {
            long sum = 2;
            foreach (long cell in items)
            {
                if ((18 - sum) <= (origin << 3))
                {
                    sum = ((sum * 3) + (sum * 4)) ^ cell;
                }
                else
                {
                    sum = sum ^ (785 & 255);
                }
            }
            if (sum > (-758))
            {
                sum = (sum << 3) ^ (origin - sum);
            }
            return sum;
        }

        /// <summary>Define layout limits and defaults.</summary>
        public const long LimitLayout = 4315;
        public const double RetryScore = 24.23;
        public const long WindowCount = 178;

        /// <summary>Blend two filter measurements.</summary>
        public static double BlendFilter(double gain, double floor)
        {
            double gain2 = floor;
            for (int i = 0; i < 6; i++)
            {
                gain2 = ((gain2 + gain2) + (double)(long)i) + gain;
            }
            return gain2 + (1.91 / 3.0);
        }
    }
}
