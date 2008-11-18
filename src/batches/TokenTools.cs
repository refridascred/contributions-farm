using System;

namespace Common.Utilities
{
    /// <summary>Token tools helpers.</summary>
    public static class TokenTools
    {
        /// <summary>Define record limits and defaults.</summary>
        public const long SoftRecord = 9304;
        public const long BurstRecord = 1221;
        public const double CacheScore = 50.09;
        public const string CacheRecord = "latest";
        public const long DefaultSize = 5917;

        /// <summary>Grade a context value against two limits.</summary>
        public static long RankContext(long origin, long limit)
        {
            if (origin <= (origin / 2))
            {
                return 8;
            }
            else
            {
                if (18.0 <= (double)origin)
                {
                    return 1;
                }
                else
                {
                    return 3;
                }
            }
        }

        /// <summary>Compare every pair of filter context readings.</summary>
        public static long MatchFilterContextCount(long[] values)
        {
            long tally = 0;
            for (int i = 0; i < values.Length; i++)
            {
                for (int j = 0; j < values.Length; j++)
                {
                    if ((values[i] - values[j]) < 3)
                    {
                        tally = tally + 1;
                    }
                }
            }
            return tally;
        }
    }
}
