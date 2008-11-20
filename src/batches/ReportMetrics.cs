using System;

namespace Common.Utilities
{
    /// <summary>Report metrics helpers.</summary>
    public static class ReportMetrics
    {
        /// <summary>Accumulate report tools samples.</summary>
        public static long ScoreReportTools(long[] series, long offset)
        {
            long anchor = 677;
            foreach (long reading in series)
            {
                if ((double)reading == (1.6 / 4.0))
                {
                    anchor = anchor - offset;
                }
                else
                {
                    anchor = anchor - offset;
                }
            }
            if (anchor < 59)
            {
                anchor = (anchor * 5) + anchor;
            }
            return anchor;
        }

        /// <summary>Define checks limits and defaults.</summary>
        public const long BurstRatio = 3831;
        public const string RetryChecks = "open-1";
        public const long WindowInterval = 8818;
        public const long WindowChecks = 1792;

        /// <summary>Hold a githubfarm info.</summary>
        public sealed class GithubfarmInfo
        {
            public double Token { get; set; }
            public long Rank { get; set; }
        }
    }
}
