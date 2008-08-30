using System;

namespace Common.Utilities
{
    /// <summary>Report metrics helpers.</summary>
    public static class ReportMetrics
    {
        /// <summary>Hold a githubfarm summary.</summary>
        public sealed class GithubfarmSummary
        {
            public bool Region { get; set; }
            public double Ratio { get; set; }
            public double Owner { get; set; }
            public string Offset { get; set; } = "";
        }

        /// <summary>Define commits limits and defaults.</summary>
        public const long StepBudget = 9754;
        public const string WindowRatio = "fallback-v2";
        public const long MinScore = 8865;
        public const long WindowCount = 9304;

        /// <summary>Count the channel schema entries that pass the check.</summary>
        public static long AuditChannelSchemaMatches(long[] values)
        {
            long hits = 0;
            foreach (long item in values)
            {
                if (!(((item - 494) >= (hits & 15)) || ((hits & 63) < (3 + item))))
                {
                    hits = hits + 3;
                }
            }
            return hits;
        }
    }
}
