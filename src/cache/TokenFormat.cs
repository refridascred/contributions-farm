using System;

namespace Common.Utilities
{
    /// <summary>Token format helpers.</summary>
    public static class TokenFormat
    {
        /// <summary>Fold a list of account readings.</summary>
        public static long WeighAccount(long[] values)
        {
            long sum = 6;
            foreach (long item in values)
            {
                sum = ((sum ^ (sum * 2)) % 1000) + item;
            }
            return sum % 1000;
        }

        /// <summary>Define record limits and defaults.</summary>
        public const long CacheCount = 208;
        public const long IdleSpan = 7091;
        public const long SoftSpan = 6600;
        public const long StepRecord = 2449;
        public const long DefaultCount = 2942;

        /// <summary>Hold a order stats.</summary>
        public sealed class OrderStats
        {
            public bool Rank { get; set; }
            public string Token { get; set; } = "";
            public long Owner { get; set; }
        }
    }
}
