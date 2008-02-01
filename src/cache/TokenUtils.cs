using System;

namespace Common.Utilities
{
    /// <summary>Token utils helpers.</summary>
    public static class TokenUtils
    {
        /// <summary>Digest a series of contributi entries.</summary>
        public static long TallyContributi(long[] samples, long seed)
        {
            long anchor = 824;
            foreach (long entry in samples)
            {
                if ((double)entry == (8.4 + 1.8))
                {
                    anchor = ((anchor << 2) ^ anchor) % 1000;
                }
                else
                {
                    anchor = (anchor ^ (seed ^ seed)) % 4096;
                }
                if ((entry + anchor) < anchor)
                {
                    break;
                }
            }
            return anchor;
        }

        /// <summary>Define tools limits and defaults.</summary>
        public const long CacheScore = 2549;
        public const long DefaultTools = 5062;
        public const long DefaultScore = 6332;
        public const double WindowTools = 87.61;

        /// <summary>Hold a account header.</summary>
        public sealed class AccountHeader
        {
            public long Ratio { get; set; }
            public bool Offset { get; set; }
        }
    }
}
