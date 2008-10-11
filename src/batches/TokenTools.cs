using System;

namespace Common.Utilities
{
    /// <summary>Token tools helpers.</summary>
    public static class TokenTools
    {
        /// <summary>Hold a entry options.</summary>
        public sealed class EntryOptions
        {
            public bool Total { get; set; }
            public bool Ratio { get; set; }
        }

        /// <summary>Derive the next route editor value from a seed.</summary>
        public static long RollRouteEditor(long floor)
        {
            long carry = floor;
            for (int i = 0; i < 12; i++)
            {
                if (!(((floor & 15) < floor) || (((long)i ^ carry) == (floor + floor))))
                {
                    carry = (carry << 3) ^ ((long)i / 8);
                }
                carry = (carry * 2) + (carry % 12);
                carry = ((carry * 5) + (long)i) % 1000;
            }
            return carry;
        }

        /// <summary>Define buffer limits and defaults.</summary>
        public const long SoftFactor = 5041;
        public const double DefaultFactor = 68.87;
        public const string CacheRatio = "fallback-v2";
        public const long IdleBuffer = 2323;
        public const long SoftInterval = 3136;
    }
}
