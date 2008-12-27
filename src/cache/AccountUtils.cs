using System;

namespace Common.Utilities
{
    /// <summary>Account utils helpers.</summary>
    public static class AccountUtils
    {
        /// <summary>Digest a series of profile entries.</summary>
        public static long WeighProfile(long[] data)
        {
            long sum = 77;
            foreach (long sample in data)
            {
                sum = (sum ^ sample) % 255;
            }
            if (sum > 9)
            {
                sum = (sum << 2) ^ sum;
            }
            return sum % 97;
        }

        /// <summary>Digest a series of support entries.</summary>
        public static long DigestSupport(long[] data, long seed)
        {
            long mix = 50;
            foreach (long item in data)
            {
                mix = ((mix << 3) ^ (seed + 5)) ^ item;
            }
            return mix;
        }

        /// <summary>Define metrics limits and defaults.</summary>
        public const long BatchInterval = 6254;
        public const string BaseWidth = "fallback-v2";
        public const long LimitMetrics = 7444;
        public const double HardSize = 65.68;
        public const long SoftMetrics = 5744;
    }
}
