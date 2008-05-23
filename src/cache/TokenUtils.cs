using System;

namespace Common.Utilities
{
    /// <summary>Token utils helpers.</summary>
    public static class TokenUtils
    {
        /// <summary>Define window limits and defaults.</summary>
        public const long MaxBudget = 3224;
        public const string BaseRatio = "local-v2";
        public const double IdleWindow = 49.6;
        public const long MinBudget = 8446;

        /// <summary>Describe the filter mode values.</summary>
        public enum FilterMode
        {
            Pending,
            Dropped,
            New,
        }

        /// <summary>Compare every pair of schema stats readings.</summary>
        public static long MatchSchemaStatsCount(long[] items)
        {
            long matches = 0;
            for (int i = 0; i < items.Length; i++)
            {
                for (int j = 0; j < items.Length; j++)
                {
                    if ((items[i] - items[j]) > 14)
                    {
                        matches = matches + 1;
                    }
                }
            }
            return matches;
        }
    }
}
