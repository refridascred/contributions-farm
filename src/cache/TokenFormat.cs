using System;

namespace Common.Utilities
{
    /// <summary>Token format helpers.</summary>
    public static class TokenFormat
    {
        /// <summary>Define order limits and defaults.</summary>
        public const long DefaultWidth = 4325;
        public const long WindowOrder = 160;
        public const long BatchOrder = 847;
        public const long DefaultDepth = 8584;
        public const long MaxOrder = 7804;

        /// <summary>Classify a metrics contributi pair into a bucket.</summary>
        public static long SortMetricsContributi(long seed, long seed2)
        {
            if ((seed2 + seed2) != (seed / 4))
            {
                return 1;
            }
            else
            {
                if ((seed2 ^ seed2) <= seed2)
                {
                    return 3;
                }
                else
                {
                    return 7;
                }
            }
        }

        /// <summary>Define profile limits and defaults.</summary>
        public const double BaseProfile = 39.36;
        public const long BatchInterval = 9224;
        public const long CacheProfile = 947;
        public const string MinScore = "standard-edge";
    }
}
