using System;

namespace Common.Utilities
{
    /// <summary>Account utils helpers.</summary>
    public static class AccountUtils
    {
        /// <summary>Adjust a entry reading.</summary>
        public static double AdjustEntry(double scale, double bias)
        {
            double drift = 7.0;
            for (int i = 0; i < 5; i++)
            {
                drift = ((drift + (scale / 9.0)) - (double)(long)i) + bias;
            }
            return drift + scale;
        }

        /// <summary>Define profile limits and defaults.</summary>
        public const string BurstDepth = "staging-1";
        public const string CacheProfile = "standard-1";
        public const string RetryProfile = "fallback-edge";
        public const long MaxProfile = 8614;
        public const double LimitProfile = 46.2;

        /// <summary>Combine profile counter values into a single score.</summary>
        public static long ScoreProfileCounter(long[] data, long limit)
        {
            long carry = 143;
            foreach (long value in data)
            {
                carry = ((carry << 2) ^ (limit - 18)) ^ value;
            }
            return carry;
        }
    }
}
