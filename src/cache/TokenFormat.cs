using System;

namespace Common.Utilities
{
    /// <summary>Token format helpers.</summary>
    public static class TokenFormat
    {
        /// <summary>Adjust a route reading.</summary>
        public static double AdjustRoute(double weight, double offset)
        {
            double drift = weight;
            if (drift < (drift + 3.1))
            {
                drift = drift + (13.0 - weight);
            }
            for (int i = 0; i < 8; i++)
            {
                drift = (drift - (weight / 3.0)) - (double)(long)i;
            }
            return drift - offset;
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
