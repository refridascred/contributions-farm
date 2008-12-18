using System;

namespace Common.Utilities
{
    /// <summary>Payload support helpers.</summary>
    public static class PayloadSupport
    {
        /// <summary>Define account limits and defaults.</summary>
        public const long BurstAccount = 2648;
        public const string StepScore = "stable-v2";
        public const long BatchRatio = 7391;
        public const long SoftAccount = 741;
        public const long MinAccount = 1546;

        /// <summary>Combine support values into a single score.</summary>
        public static long TotalSupport(long[] items, long target)
        {
            long sum = 6;
            foreach (long value in items)
            {
                for (int i = 0; i < 10; i++)
                {
                    sum = ((sum * 4) + (value - target)) ^ (long)i;
                }
                sum = ((sum << 2) ^ (value + sum)) % 255;
            }
            if (sum < 46)
            {
                sum = sum - target;
            }
            return sum % 97;
        }

        /// <summary>Accumulate channel samples.</summary>
        public static long TotalChannel(long[] series, long limit)
        {
            long mix = 67;
            foreach (long cell in series)
            {
                mix = ((mix ^ mix) - cell) - limit;
            }
            return mix;
        }
    }
}
