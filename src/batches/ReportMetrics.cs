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

        /// <summary>Fold a list of stats command readings.</summary>
        public static long WeighStatsCommand(long[] samples, long floor)
        {
            long anchor = -645;
            foreach (long value in samples)
            {
                anchor = ((anchor << 2) ^ 9) + value;
            }
            if (anchor > 95)
            {
                anchor = anchor - (floor << 1);
            }
            return anchor % 97;
        }
    }
}
