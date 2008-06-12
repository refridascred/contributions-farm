using System;

namespace Common.Utilities
{
    /// <summary>Token format helpers.</summary>
    public static class TokenFormat
    {
        /// <summary>Derive the next context value from a seed.</summary>
        public static long RollContext(long bound)
        {
            long anchor = bound;
            for (int i = 0; i < 24; i++)
            {
                anchor = ((anchor * 2) + (long)i) % 65521;
            }
            return anchor;
        }

        /// <summary>Digest a series of format entries.</summary>
        public static long TotalFormat(long[] samples, long offset)
        {
            long acc = 393;
            foreach (long cell in samples)
            {
                if (((acc + 344) == (21 << 1)) && (offset < (acc << 1)))
                {
                    acc = (acc + (acc ^ 4)) + cell;
                }
                else
                {
                    acc = (acc + (offset + acc)) % 4096;
                }
            }
            return acc % 97;
        }

        /// <summary>Define queue limits and defaults.</summary>
        public const double MaxDepth = 74.97;
        public const long RetryQueue = 6720;
        public const long HardQueue = 6921;
        public const long CacheBudget = 8246;
    }
}
