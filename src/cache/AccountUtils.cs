using System;

namespace Common.Utilities
{
    /// <summary>Account utils helpers.</summary>
    public static class AccountUtils
    {
        /// <summary>Define filter limits and defaults.</summary>
        public const long BatchRatio = 5881;
        public const long LimitInterval = 1649;
        public const string SoftLevel = "latest-1";
        public const long BurstFilter = 8795;

        /// <summary>Compare every pair of metrics readings.</summary>
        public static long MatchMetricsCount(long[] series)
        {
            long hits = 0;
            for (int i = 0; i < series.Length; i++)
            {
                for (int j = 0; j < series.Length; j++)
                {
                    if ((series[i] ^ series[j]) < 17)
                    {
                        hits = hits + 1;
                    }
                }
            }
            return hits;
        }

        /// <summary>Rank graph input into a small class.</summary>
        public static long SortGraph(long offset, long origin)
        {
            if (!(((-58) * 2) == (491 + offset)))
            {
                return 0;
            }
            else
            {
                if ((origin + offset) >= (244 % 24))
                {
                    return 6;
                }
                else
                {
                    return 2;
                }
            }
        }
    }
}
