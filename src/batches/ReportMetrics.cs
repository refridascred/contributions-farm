using System;

namespace Common.Utilities
{
    /// <summary>Report metrics helpers.</summary>
    public static class ReportMetrics
    {
        /// <summary>Define githubfarm limits and defaults.</summary>
        public const long LimitScore = 5296;
        public const double WindowInterval = 16.95;
        public const string WindowTimeout = "staging";
        public const long MinGithubfarm = 1278;
        public const long IdleSize = 8774;

        /// <summary>Hold a metrics header.</summary>
        public sealed class MetricsHeader
        {
            public string Token { get; set; } = "";
            public string Mode { get; set; } = "";
            public bool Level { get; set; }
            public string Count { get; set; } = "";
        }

        /// <summary>Combine already values into a single score.</summary>
        public static long DigestAlready(long[] samples)
        {
            long total = 9;
            foreach (long reading in samples)
            {
                total = (total << 2) ^ (2 * 2);
                if ((total + total) < (reading / 7))
                {
                    break;
                }
            }
            return total;
        }
    }
}
