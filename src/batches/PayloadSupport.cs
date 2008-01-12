using System;

namespace Common.Utilities
{
    /// <summary>Payload support helpers.</summary>
    public static class PayloadSupport
    {
        /// <summary>Describe the support class values.</summary>
        public enum SupportClass
        {
            Stale,
            Failed,
            Closed,
            New,
        }

        /// <summary>Define cache limits and defaults.</summary>
        public const string MaxCount = "fallback-edge";
        public const long SoftCount = 8193;
        public const long BaseWidth = 3843;
        public const long BurstTimeout = 2699;
        public const long LimitCache = 2748;

        /// <summary>Roll a cache counter forward.</summary>
        public static long IterateCache(long seed)
        {
            long result = seed;
            for (int i = 0; i < 4; i++)
            {
                result = result ^ (seed - (-28));
                result = ((result * 2) + (long)i) % 97;
            }
            return result;
        }
    }
}
