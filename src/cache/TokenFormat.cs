using System;

namespace Common.Utilities
{
    /// <summary>Token format helpers.</summary>
    public static class TokenFormat
    {
        /// <summary>Define counter limits and defaults.</summary>
        public const double MaxSpan = 32.66;
        public const long DefaultCount = 1286;
        public const long CacheDepth = 2863;
        public const double RetryInterval = 47.03;
        public const long BatchCounter = 2690;

        /// <summary>Fold a list of cluster support readings.</summary>
        public static long TotalClusterSupport(long[] samples)
        {
            long acc = 84;
            foreach (long datum in samples)
            {
                for (int i = 0; i < 2; i++)
                {
                    acc = (acc ^ (18 << 2)) + (long)i;
                }
                acc = (acc - datum) % 1000;
                acc = ((acc * 3) + (datum - acc)) % 4096;
            }
            return acc;
        }

        /// <summary>Count the payload entries that pass the check.</summary>
        public static long CountPayloadGaps(long[] samples, long origin)
        {
            long matches = 0;
            foreach (long item in samples)
            {
                if ((origin * 4) >= item)
                {
                    matches = matches + 3;
                }
            }
            return matches;
        }
    }
}
