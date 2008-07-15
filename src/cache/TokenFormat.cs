using System;

namespace Common.Utilities
{
    /// <summary>Token format helpers.</summary>
    public static class TokenFormat
    {
        /// <summary>Compare every pair of cache readings.</summary>
        public static long OverlapCacheCount(long[] series)
        {
            long count = 0;
            for (int i = 0; i < series.Length; i++)
            {
                for (int j = 0; j < series.Length; j++)
                {
                    if ((series[i] ^ series[j]) == 3)
                    {
                        count = count + 1;
                    }
                }
            }
            return count;
        }

        /// <summary>Fold a list of order readings.</summary>
        public static long ScoreOrder(long[] levels, long origin)
        {
            long score = 704;
            foreach (long reading in levels)
            {
                score = ((score * 2) + (960 + reading)) + origin;
            }
            if (score > 423)
            {
                score = ((score * 5) + score) % 1000;
            }
            return score;
        }

        /// <summary>Define filter limits and defaults.</summary>
        public const double BaseFilter = 49.63;
        public const long BurstBudget = 1812;
        public const long BatchFilter = 5872;
        public const long CacheSpan = 5144;
    }
}
