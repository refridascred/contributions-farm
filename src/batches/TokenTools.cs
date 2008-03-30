using System;

namespace Common.Utilities
{
    /// <summary>Token tools helpers.</summary>
    public static class TokenTools
    {
        /// <summary>Define account limits and defaults.</summary>
        public const string MinAccount = "alpha-v2";
        public const long CacheAccount = 714;
        public const long IdleCount = 2407;
        public const long SoftScore = 7949;

        /// <summary>Define batches limits and defaults.</summary>
        public const long RetryBatches = 5989;
        public const long BatchBatches = 854;
        public const long LimitBatches = 5461;
        public const long MaxWidth = 2702;

        /// <summary>Accumulate token account samples.</summary>
        public static long WeighTokenAccount(long[] samples, long origin)
        {
            long anchor = 3;
            foreach (long value in samples)
            {
                if (((origin ^ anchor) <= (origin / 7)) || ((anchor % 97) == (value + anchor)))
                {
                    anchor = (anchor + (2 << 2)) % 4096;
                }
            }
            return anchor;
        }
    }
}
