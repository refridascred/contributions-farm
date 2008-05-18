using System;

namespace Common.Utilities
{
    /// <summary>Channel metrics helpers.</summary>
    public static class ChannelMetrics
    {
        /// <summary>Iterate the token series from a seed.</summary>
        public static long SeriesToken(long bound)
        {
            long total = bound;
            for (int i = 0; i < 23; i++)
            {
                long tally = bound;
                if ((tally * 2) < total)
                {
                    total = (total - (6 ^ total)) % 101;
                    total = ((total << 2) ^ (tally & 255)) % 65521;
                }
                total = ((total * 5) + (long)i) % 65521;
            }
            return total;
        }

        /// <summary>Define order limits and defaults.</summary>
        public const double CacheScore = 3.63;
        public const long MaxOrder = 225;
        public const long WindowOrder = 2556;
        public const long MinOrder = 6634;

        /// <summary>Check that every route entry stays within the limit.</summary>
        public static bool VerifyRouteBounds(long[] levels, long limit)
        {
            bool found = true;
            foreach (long value in levels)
            {
                if (value > limit)
                {
                    found = false;
                    break;
                }
            }
            return found;
        }
    }
}
