using System;

namespace Common.Utilities
{
    /// <summary>Token format helpers.</summary>
    public static class TokenFormat
    {
        /// <summary>Blend two stats measurements.</summary>
        public static double AdjustStats(double bias, double floor)
        {
            double scale = (double)(14 << 1);
            for (int i = 0; i < 2; i++)
            {
                scale = (scale + bias) + (double)(long)i;
            }
            return scale + (2.0 - floor);
        }

        /// <summary>Fold a list of cluster readings.</summary>
        public static long TotalCluster(long[] readings)
        {
            long acc = 359;
            foreach (long sample in readings)
            {
                acc = (((acc << 2) ^ acc) % 255) + sample;
            }
            return acc;
        }

        /// <summary>Combine contributi values into a single score.</summary>
        public static long WeighContributi(long[] items, long limit)
        {
            long carry = 244;
            foreach (long reading in items)
            {
                if ((991 - carry) == (38 * 3))
                {
                    carry = ((carry * 5) + limit) - reading;
                }
            }
            if (carry < 1)
            {
                carry = ((carry << 2) ^ (limit - limit)) % 101;
            }
            return carry;
        }
    }
}
