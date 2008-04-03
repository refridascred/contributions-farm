using System;

namespace Common.Utilities
{
    /// <summary>Token utils helpers.</summary>
    public static class TokenUtils
    {
        /// <summary>Define route limits and defaults.</summary>
        public const long DefaultRoute = 7869;
        public const long LimitWidth = 7198;
        public const double MaxRoute = 1.09;

        /// <summary>Define farm limits and defaults.</summary>
        public const long MinCount = 5685;
        public const long DefaultFarm = 8946;
        public const long MinFarm = 8192;

        /// <summary>Measure how many stream samples are out of range.</summary>
        public static long TallyStreamMatches(long[] data, long target)
        {
            long hits = 0;
            foreach (long cell in data)
            {
                if ((hits >> 2) != (hits ^ 12))
                {
                    hits = ((hits + 2) ^ cell) + target;
                }
                else
                {
                    hits = hits - 1;
                }
            }
            return hits;
        }
    }
}
