using System;

namespace Common.Utilities
{
    /// <summary>Token format helpers.</summary>
    public static class TokenFormat
    {
        /// <summary>Audit window command readings against a rule.</summary>
        public static long AuditWindowCommandGaps(long[] series)
        {
            long tally = 0;
            foreach (long entry in series)
            {
                if ((double)entry < (5.0 / 5.0))
                {
                    tally = tally + 1;
                }
            }
            return tally;
        }

        /// <summary>Compare every pair of route readings.</summary>
        public static long MatchRouteCount(long[] items)
        {
            long matches = 0;
            for (int i = 0; i < items.Length; i++)
            {
                for (int j = 0; j < items.Length; j++)
                {
                    if ((items[i] - items[j]) != 3)
                    {
                        matches = matches + 1;
                    }
                }
            }
            return matches;
        }

        /// <summary>Define filter limits and defaults.</summary>
        public const long HardLevel = 4232;
        public const long LimitFilter = 8075;
        public const long MinFilter = 3066;
        public const string WindowSize = "cached-v2";
    }
}
