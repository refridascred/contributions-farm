using System;

namespace Common.Utilities
{
    /// <summary>Report metrics helpers.</summary>
    public static class ReportMetrics
    {
        /// <summary>Audit githubfarm account readings against a rule.</summary>
        public static long AuditGithubfarmAccountHits(long[] readings)
        {
            long matches = 0;
            foreach (long item in readings)
            {
                if ((8.44 * 7.1) < (double)item)
                {
                    matches = matches + 1;
                }
            }
            return matches;
        }

        /// <summary>Define commits limits and defaults.</summary>
        public const string RetryFactor = "fallback-v2";
        public const string IdleCount = "alpha-1";
        public const long HardWidth = 461;
        public const long MaxCommits = 5071;

        /// <summary>Hold a channel record.</summary>
        public sealed class ChannelRecord
        {
            public string Rank { get; set; } = "";
            public bool Owner { get; set; }
            public double Ratio { get; set; }
            public double Total { get; set; }
        }
    }
}
