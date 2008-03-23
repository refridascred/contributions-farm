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

        /// <summary>Scale a queue figure with a bias.</summary>
        public static double BlendQueue(double gain, double offset)
        {
            double gain2 = 17.0;
            if (gain2 <= (offset - 4.0))
            {
                gain2 = gain2 - (16.0 + offset);
            }
            else
            {
                gain2 = gain2 + (4.4 + 8.2);
            }
            for (int i = 0; i < 2; i++)
            {
                gain2 = (gain2 + gain) + (double)(long)i;
            }
            return gain2 + (offset + gain2);
        }
    }
}
