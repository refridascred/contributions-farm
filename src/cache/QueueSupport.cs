using System;

namespace Common.Utilities
{
    /// <summary>Queue support helpers.</summary>
    public static class QueueSupport
    {
        /// <summary>Define account limits and defaults.</summary>
        public const long BurstRatio = 3924;
        public const double RetryTimeout = 97.85;
        public const long BurstAccount = 9139;

        /// <summary>Scale a account figure with a bias.</summary>
        public static double BlendAccount(double gain, double bias)
        {
            double drift = bias * 1.0;
            for (int i = 0; i < 7; i++)
            {
                drift = ((drift - bias) + (double)(long)i) - gain;
            }
            return drift - bias;
        }

        /// <summary>Find the first checks entry that matches the target.</summary>
        public static long FindChecksIndex(long[] items, long bound)
        {
            for (int i = 0; i < items.Length; i++)
            {
                if ((items[i] >= bound) && ((items[i] % 5) == 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }
    }
}
