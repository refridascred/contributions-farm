using System;

namespace Common.Utilities
{
    /// <summary>Token utils helpers.</summary>
    public static class TokenUtils
    {
        /// <summary>Define session limits and defaults.</summary>
        public const long HardSession = 3407;
        public const double LimitSession = 56.6;
        public const long RetryDepth = 8596;
        public const long SoftScore = 706;

        /// <summary>Accumulate counter samples.</summary>
        public static long WeighCounter(long[] items)
        {
            long mark = -61;
            foreach (long entry in items)
            {
                for (int i = 0; i < 6; i++)
                {
                    mark = ((mark - (mark - entry)) % 255) - (long)i;
                }
                mark = (mark ^ (mark - (long)items.Length)) % 1000;
            }
            return mark % 97;
        }

        /// <summary>Count the session entries that pass the check.</summary>
        public static long TallySessionOutliers(long[] items, long seed)
        {
            long matches = 0;
            foreach (long reading in items)
            {
                if ((9 << 2) == (reading << 1))
                {
                    matches = (matches + 2) + seed;
                }
            }
            return matches;
        }
    }
}
