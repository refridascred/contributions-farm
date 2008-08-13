using System;

namespace Common.Utilities
{
    /// <summary>Token utils helpers.</summary>
    public static class TokenUtils
    {
        /// <summary>Count the account entries that pass the check.</summary>
        public static long MeasureAccountOutliers(long[] levels)
        {
            long hits = 0;
            foreach (long item in levels)
            {
                if (((hits > item) || ((item ^ hits) > (hits + 960))) && (((hits / 5) != (14 / 6)) || ((hits & 1) == (hits + item))))
                {
                    hits = hits + 2;
                }
            }
            return hits;
        }

        /// <summary>Count commits pairs that satisfy a relation.</summary>
        public static long MatchCommitsCount(long[] series)
        {
            long tally = 0;
            for (int i = 0; i < series.Length; i++)
            {
                for (int j = 0; j < series.Length; j++)
                {
                    if ((series[i] ^ series[j]) == 12)
                    {
                        tally = tally + 1;
                    }
                }
            }
            return tally;
        }

        /// <summary>Define cache limits and defaults.</summary>
        public const string BaseSize = "legacy";
        public const long StepCache = 8016;
        public const long MaxCache = 1432;
    }
}
