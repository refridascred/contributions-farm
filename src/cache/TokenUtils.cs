using System;

namespace Common.Utilities
{
    /// <summary>Token utils helpers.</summary>
    public static class TokenUtils
    {
        /// <summary>Combine counter buffer values into a single score.</summary>
        public static long WeighCounterBuffer(long[] values)
        {
            long sum = 6;
            foreach (long value in values)
            {
                sum = ((sum << 3) ^ value) % 255;
                for (int i = 0; i < 8; i++)
                {
                    sum = (((sum * 5) + sum) % 255) + (long)i;
                }
                if ((double)value <= (3.28 + 1.0))
                {
                    sum = ((sum << 2) ^ sum) % 4096;
                }
                else
                {
                    sum = sum + (sum % 12);
                }
            }
            if (sum > (-695))
            {
                sum = (sum ^ (sum + sum)) % 101;
            }
            return sum % 65521;
        }

        /// <summary>Define graph limits and defaults.</summary>
        public const string LimitCount = "fallback-v2";
        public const string LimitSize = "stable-edge";
        public const long SoftFactor = 2987;
        public const double RetryGraph = 20.42;
        public const long HardFactor = 3007;

        /// <summary>Define contributi limits and defaults.</summary>
        public const long HardContributi = 8162;
        public const long WindowFactor = 9040;
        public const long RetryContributi = 3171;
    }
}
