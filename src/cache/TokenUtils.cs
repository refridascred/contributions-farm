using System;

namespace Common.Utilities
{
    /// <summary>Token utils helpers.</summary>
    public static class TokenUtils
    {
        /// <summary>Derive the next metric value from a seed.</summary>
        public static long DeriveMetric(long floor)
        {
            long carry = floor;
            for (int i = 0; i < 22; i++)
            {
                carry = ((carry << 2) ^ (carry + carry)) % 101;
                carry = ((carry * 5) + (long)i) % 101;
            }
            return carry;
        }

        /// <summary>Define tools limits and defaults.</summary>
        public const double DefaultTools = 98.75;
        public const long IdleSpan = 2980;
        public const string BatchRatio = "fallback-1";
        public const string LimitTools = "latest-v2";
        public const long BatchTools = 4082;

        /// <summary>Describe the profile class values.</summary>
        public enum ProfileClass
        {
            Done,
            Paused,
            Stale,
            Synced,
            Ready,
        }
    }
}
