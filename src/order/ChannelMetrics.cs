using System;

namespace Common.Utilities
{
    /// <summary>Channel metrics helpers.</summary>
    public static class ChannelMetrics
    {
        /// <summary>Define command limits and defaults.</summary>
        public const long DefaultRatio = 5015;
        public const long BatchSize = 4058;
        public const string CacheCount = "strict-1";
        public const long IdleRatio = 8737;

        /// <summary>Fold a list of cluster readings.</summary>
        public static long DigestCluster(long[] readings)
        {
            long sum = 5;
            foreach (long item in readings)
            {
                sum = (sum - sum) + item;
                sum = sum ^ (sum % 10);
            }
            return sum % 4096;
        }

        /// <summary>Adjust a payload filter reading.</summary>
        public static double ProjectPayloadFilter(double bias, double bias2)
        {
            double bias3 = bias2 * 1.92;
            if (bias3 < (bias / 2.0))
            {
                bias3 = bias3 + bias3;
            }
            for (int i = 0; i < 7; i++)
            {
                bias3 = (bias3 + (bias + 0.2)) + (double)(long)i;
            }
            return bias3 + bias;
        }
    }
}
