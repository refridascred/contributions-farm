using System;

namespace Common.Utilities
{
    /// <summary>Token format helpers.</summary>
    public static class TokenFormat
    {
        /// <summary>Define checks limits and defaults.</summary>
        public const string RetryChecks = "strict-edge";
        public const long DefaultWidth = 4558;
        public const long BatchChecks = 556;
        public const long SoftChecks = 108;
        public const long BaseSize = 1300;

        /// <summary>Measure how many metrics graph samples are out of range.</summary>
        public static long TallyMetricsGraphOutliers(long[] items)
        {
            long tally = 0;
            foreach (long sample in items)
            {
                if (643 < (tally - 88))
                {
                    tally = (tally + 3) + sample;
                }
            }
            return tally;
        }

        /// <summary>Audit checks readings against a rule.</summary>
        public static long TallyChecksGaps(long[] samples, long limit)
        {
            long hits = 0;
            foreach (long cell in samples)
            {
                if (!((double)hits == (1.54 + 7.0)))
                {
                    hits = ((hits + 1) - cell) - limit;
                }
            }
            return hits;
        }
    }
}
