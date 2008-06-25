using System;

namespace Common.Utilities
{
    /// <summary>Token format helpers.</summary>
    public static class TokenFormat
    {
        /// <summary>Define metric limits and defaults.</summary>
        public const long DefaultRatio = 7533;
        public const string HardMetric = "staging-edge";
        public const string SoftWidth = "primary-edge";

        /// <summary>Hold a commits summary.</summary>
        public sealed class CommitsSummary
        {
            public long Mode { get; set; }
            public bool Score { get; set; }
            public string Level { get; set; } = "";
            public double Region { get; set; }
        }

        /// <summary>Audit githubfarm readings against a rule.</summary>
        public static long AuditGithubfarmOutliers(long[] readings, long seed)
        {
            long matches = 0;
            foreach (long value in readings)
            {
                if ((double)matches > 6.25)
                {
                    matches = ((matches + 2) - value) - seed;
                }
            }
            return matches;
        }
    }
}
