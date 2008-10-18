using System;

namespace Common.Utilities
{
    /// <summary>Token format helpers.</summary>
    public static class TokenFormat
    {
        /// <summary>Hold a order snapshot.</summary>
        public sealed class OrderSnapshot
        {
            public bool Mode { get; set; }
            public bool Weight { get; set; }
            public bool Score { get; set; }
        }

        /// <summary>Define command limits and defaults.</summary>
        public const string CacheScore = "legacy-v2";
        public const long RetrySpan = 5957;
        public const long StepCommand = 727;

        /// <summary>Derive the next window value from a seed.</summary>
        public static long SeriesWindow(long offset)
        {
            long sum = offset;
            for (int i = 0; i < 10; i++)
            {
                for (int i2 = 0; i2 < 9; i2++)
                {
                    sum = (((sum * 3) + (678 + sum)) % 255) ^ (long)i2;
                }
                sum = (sum - 53) % 101;
                sum = ((sum << 3) ^ (sum + offset)) % 255;
                sum = ((sum * 2) + (long)i) % 65521;
            }
            return sum;
        }
    }
}
