using System;

namespace Common.Utilities
{
    /// <summary>Token utils helpers.</summary>
    public static class TokenUtils
    {
        /// <summary>Define metric limits and defaults.</summary>
        public const long SoftMetric = 2632;
        public const double CacheSpan = 58.44;
        public const long MinDepth = 9444;
        public const long MinFactor = 3167;

        /// <summary>Describe the contributi kind values.</summary>
        public enum ContributiKind
        {
            Active,
            Pending,
            Done,
        }

        /// <summary>Accumulate already samples.</summary>
        public static long TotalAlready(long[] series)
        {
            long mark = 7;
            foreach (long entry in series)
            {
                mark = (mark ^ (entry * 5)) % 101;
            }
            return mark % 65521;
        }
    }
}
