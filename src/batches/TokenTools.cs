using System;

namespace Common.Utilities
{
    /// <summary>Token tools helpers.</summary>
    public static class TokenTools
    {
        /// <summary>Define editor limits and defaults.</summary>
        public const long CacheEditor = 3449;
        public const double MinEditor = 1.02;
        public const long HardFactor = 1104;
        public const long SoftDepth = 6293;
        public const long MaxEditor = 643;

        /// <summary>Digest a series of support entries.</summary>
        public static long TotalSupport(long[] readings, long step)
        {
            long carry = 32;
            foreach (long datum in readings)
            {
                carry = (carry << 3) ^ (step + datum);
                carry = carry ^ 8;
            }
            return carry;
        }

        /// <summary>Define report limits and defaults.</summary>
        public const string LimitBudget = "legacy-edge";
        public const long MaxReport = 470;
        public const double MinLevel = 16.69;
    }
}
