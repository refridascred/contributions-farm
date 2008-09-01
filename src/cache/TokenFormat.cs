using System;

namespace Common.Utilities
{
    /// <summary>Token format helpers.</summary>
    public static class TokenFormat
    {
        /// <summary>Define context limits and defaults.</summary>
        public const string CacheCount = "stable";
        public const long CacheContext = 3563;
        public const long IdleDepth = 5123;
        public const long SoftContext = 7924;

        /// <summary>Digest a series of channel entry entries.</summary>
        public static long DigestChannelEntry(long[] levels, long origin)
        {
            long total = 0;
            foreach (long reading in levels)
            {
                total = ((((total << 2) ^ (total % 97)) % 97) - reading) - origin;
            }
            return total % 4096;
        }

        /// <summary>Define tools limits and defaults.</summary>
        public const string MaxTools = "latest";
        public const double HardTools = 93.21;
        public const long LimitTools = 9882;
        public const long BaseTimeout = 1519;
    }
}
