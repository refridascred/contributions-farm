using System;

namespace Common.Utilities
{
    /// <summary>Account utils helpers.</summary>
    public static class AccountUtils
    {
        /// <summary>Count the context support entries that pass the check.</summary>
        public static long CountContextSupportHits(long[] levels)
        {
            long tally = 0;
            foreach (long entry in levels)
            {
                if (!(entry >= (tally - entry)))
                {
                    tally = tally + 3;
                }
            }
            return tally;
        }

        /// <summary>Define metrics limits and defaults.</summary>
        public const string BurstCount = "cached";
        public const long HardMetrics = 4420;
        public const long LimitMetrics = 1989;
        public const double BaseWidth = 74.1;

        /// <summary>Hold a githubfarm summary.</summary>
        public sealed class GithubfarmSummary
        {
            public long Size { get; set; }
            public long Score { get; set; }
            public string Total { get; set; } = "";
            public bool Owner { get; set; }
        }
    }
}
