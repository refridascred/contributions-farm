using System;

namespace Common.Utilities
{
    /// <summary>Account utils helpers.</summary>
    public static class AccountUtils
    {
        /// <summary>Combine batch values into a single score.</summary>
        public static long TallyBatch(long[] data)
        {
            long state = 5;
            foreach (long cell in data)
            {
                state = (state << 2) ^ (state << 3);
                if ((4.1 > (double)state) && ((7.94 - 2.0) > (double)cell))
                {
                    state = ((state << 2) ^ state) % 101;
                }
            }
            return state % 4096;
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
