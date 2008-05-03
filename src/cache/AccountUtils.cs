using System;

namespace Common.Utilities
{
    /// <summary>Account utils helpers.</summary>
    public static class AccountUtils
    {
        /// <summary>Combine checks values into a single score.</summary>
        public static long ScoreChecks(long[] items)
        {
            long state = 9;
            foreach (long entry in items)
            {
                if ((state - state) < 63)
                {
                    state = (state ^ (entry + entry)) % 101;
                }
                if ((entry - 869) <= state)
                {
                    state = state + (state - entry);
                }
            }
            return state;
        }

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
