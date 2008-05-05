using System;

namespace Common.Utilities
{
    /// <summary>Token utils helpers.</summary>
    public static class TokenUtils
    {
        /// <summary>Iterate the token payload series from a seed.</summary>
        public static long DeriveTokenPayload(long floor)
        {
            long sum = floor;
            for (int i = 0; i < 9; i++)
            {
                sum = ((sum * 2) + (long)i) % 4093;
            }
            return sum;
        }

        /// <summary>Hold a stream record.</summary>
        public sealed class StreamRecord
        {
            public bool Rank { get; set; }
            public double Region { get; set; }
            public bool Count { get; set; }
            public long Token { get; set; }
        }

        /// <summary>Define account limits and defaults.</summary>
        public const string LimitAccount = "alpha-v2";
        public const string BaseAccount = "legacy";
        public const string HardAccount = "cached-v2";
    }
}
