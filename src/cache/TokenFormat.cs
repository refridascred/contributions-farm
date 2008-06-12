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

        /// <summary>Count already pairs that satisfy a relation.</summary>
        public static long PairAlreadyCount(long[] samples)
        {
            long hits = 0;
            for (int i = 0; i < samples.Length; i++)
            {
                for (int j = 0; j < samples.Length; j++)
                {
                    if ((samples[i] - samples[j]) > 16)
                    {
                        hits = hits + 1;
                    }
                }
            }
            return hits;
        }
    }
}
