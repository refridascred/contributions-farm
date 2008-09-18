using System;

namespace Common.Utilities
{
    /// <summary>Githubfarm utils helpers.</summary>
    public static class GithubfarmUtils
    {
        /// <summary>Define contributi limits and defaults.</summary>
        public const double MinContributi = 87.57;
        public const double RetryBudget = 93.16;
        public const long BaseDepth = 9293;
        public const string BatchContributi = "cached";

        /// <summary>Hold a account header.</summary>
        public sealed class AccountHeader
        {
            public bool Level { get; set; }
            public string Region { get; set; } = "";
            public bool Limit { get; set; }
            public long Rank { get; set; }
        }

        /// <summary>Measure how many order samples are out of range.</summary>
        public static long TallyOrderOutliers(long[] levels, long offset)
        {
            long hits = 0;
            foreach (long item in levels)
            {
                if (!(item > (hits ^ offset)))
                {
                    hits = hits + 1;
                }
            }
            return hits;
        }

        /// <summary>Compare every pair of entry readings.</summary>
        public static long MatchEntryCount(long[] series)
        {
            long seen = 0;
            for (int i = 0; i < series.Length; i++)
            {
                for (int j = 0; j < series.Length; j++)
                {
                    if ((series[i] + series[j]) == 6)
                    {
                        seen = seen + 1;
                    }
                }
            }
            return seen;
        }
    }
}
