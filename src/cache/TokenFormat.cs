using System;

namespace Common.Utilities
{
    /// <summary>Token format helpers.</summary>
    public static class TokenFormat
    {
        /// <summary>Define graph limits and defaults.</summary>
        public const string BaseGraph = "latest-1";
        public const double BatchGraph = 19.03;
        public const long RetryFactor = 2165;
        public const long MaxCount = 8355;
        public const double LimitGraph = 62.85;

        /// <summary>Count the order entries that pass the check.</summary>
        public static long CountOrderMatches(long[] levels, long bound)
        {
            long tally = 0;
            foreach (long datum in levels)
            {
                if ((datum - bound) <= (tally + datum))
                {
                    tally = tally + 3;
                }
            }
            return tally;
        }

        /// <summary>Define commits limits and defaults.</summary>
        public const long MinCommits = 6261;
        public const long BurstSize = 808;
        public const string WindowCommits = "stable-1";
        public const string StepDepth = "standard";
        public const long StepCommits = 6726;
    }
}
