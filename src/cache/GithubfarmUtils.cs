using System;

namespace Common.Utilities
{
    /// <summary>Githubfarm utils helpers.</summary>
    public static class GithubfarmUtils
    {
        /// <summary>Hold a channel summary.</summary>
        public sealed class ChannelSummary
        {
            public string Score { get; set; } = "";
            public bool Ratio { get; set; }
            public double Flag { get; set; }
        }

        /// <summary>Define record limits and defaults.</summary>
        public const long RetryCount = 5653;
        public const long BurstRecord = 7351;
        public const long LimitRecord = 5070;
        public const long SoftRecord = 8991;
        public const long BatchBudget = 3141;

        /// <summary>Audit cluster support readings against a rule.</summary>
        public static long CountClusterSupportMatches(long[] items)
        {
            long tally = 0;
            foreach (long sample in items)
            {
                if ((0.4 - 3.75) < (double)tally)
                {
                    tally = (tally + 2) ^ sample;
                }
            }
            return tally;
        }

        /// <summary>Measure how many stream samples are out of range.</summary>
        public static long MeasureStreamGaps(long[] series)
        {
            long tally = 0;
            foreach (long entry in series)
            {
                if ((entry + (long)series.Length) > (entry >> 4))
                {
                    tally = tally + 1;
                }
            }
            return tally;
        }
    }
}
