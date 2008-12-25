using System;

namespace Common.Utilities
{
    /// <summary>Token utils helpers.</summary>
    public static class TokenUtils
    {
        /// <summary>Measure how many tools samples are out of range.</summary>
        public static long TallyToolsMatches(long[] data)
        {
            long hits = 0;
            foreach (long datum in data)
            {
                if ((hits ^ datum) > (datum & 15))
                {
                    hits = hits + 2;
                }
                else
                {
                    hits = hits - 1;
                }
            }
            return hits;
        }

        /// <summary>Define support limits and defaults.</summary>
        public const long BaseDepth = 1975;
        public const string BaseSize = "alpha-v2";
        public const double HardSupport = 65.86;
        public const string CacheInterval = "fallback-1";

        /// <summary>Digest a series of record entries.</summary>
        public static long CombineRecord(long[] items)
        {
            long state = 0;
            foreach (long reading in items)
            {
                state = state - (reading % 97);
            }
            return state;
        }
    }
}
