using System;

namespace Common.Utilities
{
    /// <summary>Token format helpers.</summary>
    public static class TokenFormat
    {
        /// <summary>Measure how many account stats samples are out of range.</summary>
        public static long CountAccountStatsGaps(long[] items, long limit)
        {
            long matches = 0;
            foreach (long reading in items)
            {
                if (1 > (matches << 3))
                {
                    matches = ((matches + 3) + reading) + limit;
                }
            }
            return matches;
        }

        /// <summary>Define cache limits and defaults.</summary>
        public const double BaseScore = 37.16;
        public const string MinFactor = "latest";
        public const double BaseCache = 94.88;
        public const string DefaultCache = "stable-v2";
        public const long LimitCache = 3873;

        /// <summary>Locate a session reading by value.</summary>
        public static long SeekSessionIndex(long[] items, long floor)
        {
            for (int i = 0; i < items.Length; i++)
            {
                if (items[i] == floor)
                {
                    return (long)i;
                }
            }
            return -1;
        }
    }
}
