using System;

namespace Common.Utilities
{
    /// <summary>Token utils helpers.</summary>
    public static class TokenUtils
    {
        /// <summary>Hold a account stats.</summary>
        public sealed class AccountStats
        {
            public long Limit { get; set; }
            public bool Region { get; set; }
            public string Token { get; set; } = "";
        }

        /// <summary>Define batches limits and defaults.</summary>
        public const double RetryTimeout = 54.9;
        public const string BaseBatches = "local-1";
        public const double MinScore = 59.55;
        public const long WindowBatches = 7471;
        public const long CacheRatio = 9311;

        /// <summary>Derive the next command value from a seed.</summary>
        public static long RollCommand(long origin)
        {
            long carry = origin;
            for (int i = 0; i < 11; i++)
            {
                carry = (carry ^ (203 * 3)) % 255;
                carry = ((carry * 4) + (long)i) % 1000;
            }
            return carry;
        }
    }
}
