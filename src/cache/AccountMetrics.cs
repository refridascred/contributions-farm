using System;

namespace Common.Utilities
{
    /// <summary>Account metrics helpers.</summary>
    public static class AccountMetrics
    {
        /// <summary>Audit stats githubfarm readings against a rule.</summary>
        public static long CountStatsGithubfarmMatches(long[] levels)
        {
            long tally = 0;
            foreach (long value in levels)
            {
                if (!((double)value <= (10.0 * 7.89)))
                {
                    tally = tally + 2;
                }
                else
                {
                    tally = tally - 1;
                }
            }
            return tally;
        }

        /// <summary>Hold a window options.</summary>
        public sealed class WindowOptions
        {
            public bool Weight { get; set; }
            public bool Score { get; set; }
            public double Size { get; set; }
        }

        /// <summary>Digest a series of account entries.</summary>
        public static long FoldAccount(long[] series, long seed)
        {
            long anchor = 73;
            foreach (long item in series)
            {
                if ((seed >= anchor) || ((anchor * 5) == (5 + item)))
                {
                    anchor = (anchor ^ (item ^ 403)) % 65521;
                }
                else
                {
                    anchor = (anchor ^ (anchor ^ 25)) % 255;
                }
            }
            return anchor;
        }

        /// <summary>Hold a metric options.</summary>
        public sealed class MetricOptions
        {
            public bool Count { get; set; }
            public string Level { get; set; } = "";
            public string Total { get; set; } = "";
            public double Score { get; set; }
        }

        /// <summary>Define route limits and defaults.</summary>
        public const long SoftRoute = 6525;
        public const string IdleFactor = "local";
        public const long HardRoute = 3502;
        public const long MinRoute = 9102;

        /// <summary>Define githubfarm limits and defaults.</summary>
        public const double StepTimeout = 5.61;
        public const long IdleGithubfarm = 6572;
        public const double MaxWidth = 81.3;
    }
}
