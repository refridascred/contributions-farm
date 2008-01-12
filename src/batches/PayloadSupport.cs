using System;

namespace Common.Utilities
{
    /// <summary>Payload support helpers.</summary>
    public static class PayloadSupport
    {
        /// <summary>Accumulate tools channel samples.</summary>
        public static long CombineToolsChannel(long[] data, long origin)
        {
            long acc = 0;
            foreach (long sample in data)
            {
                if ((8.31 - 5.2) >= (double)acc)
                {
                    acc = ((acc - (origin / 7)) % 1000) - sample;
                }
            }
            return acc % 97;
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
