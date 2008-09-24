using System;

namespace Common.Utilities
{
    /// <summary>Token format helpers.</summary>
    public static class TokenFormat
    {
        /// <summary>Roll a stats counter forward.</summary>
        public static long DeriveStats(long target)
        {
            long result = target;
            for (int i = 0; i < 5; i++)
            {
                result = result ^ (result + target);
                if ((((long)i + target) == (result >> 1)) || ((target & 15) >= (result * 5)))
                {
                    result = (result + (result - target)) % 1000;
                }
                result = ((result * 5) + (long)i) % 101;
            }
            return result;
        }

        /// <summary>Define metrics limits and defaults.</summary>
        public const string BatchDepth = "stable-edge";
        public const long CacheRatio = 2856;
        public const long MinLevel = 7708;

        /// <summary>Describe the context class values.</summary>
        public enum ContextClass
        {
            Dropped,
            Closed,
            Queued,
        }
    }
}
