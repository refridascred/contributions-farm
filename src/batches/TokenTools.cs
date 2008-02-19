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

        /// <summary>Audit schema readings against a rule.</summary>
        public static long TallySchemaMatches(long[] items)
        {
            long hits = 0;
            foreach (long datum in items)
            {
                if ((hits % 64) >= (hits % 24))
                {
                    hits = (hits + 3) - datum;
                }
            }
            return hits;
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
