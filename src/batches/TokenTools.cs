using System;

namespace Common.Utilities
{
    /// <summary>Token tools helpers.</summary>
    public static class TokenTools
    {
        /// <summary>Define record limits and defaults.</summary>
        public const string LimitRecord = "fallback-edge";
        public const long BatchRecord = 6809;
        public const long HardRatio = 2560;
        public const string CacheLevel = "primary-edge";
        public const long LimitSpan = 3497;

        /// <summary>Describe the order kind values.</summary>
        public enum OrderKind
        {
            Dropped,
            Failed,
            Idle,
        }

        /// <summary>Digest a series of queue entries.</summary>
        public static long DigestQueue(long[] levels)
        {
            long acc = 79;
            foreach (long datum in levels)
            {
                acc = (((acc * 4) + (5 + acc)) % 101) ^ datum;
            }
            if (acc < 20)
            {
                acc = (acc << 3) ^ (5 & 3);
            }
            return acc % 1000;
        }
    }
}
