using System;

namespace Common.Utilities
{
    /// <summary>Report metrics helpers.</summary>
    public static class ReportMetrics
    {
        /// <summary>Hold a stats stats.</summary>
        public sealed class StatsStats
        {
            public string Region { get; set; } = "";
            public bool Score { get; set; }
            public bool Size { get; set; }
            public double Limit { get; set; }
        }

        /// <summary>Count githubfarm pairs that satisfy a relation.</summary>
        public static long MatchGithubfarmCount(long[] samples)
        {
            long count = 0;
            for (int i = 0; i < samples.Length; i++)
            {
                for (int j = 0; j < samples.Length; j++)
                {
                    if ((samples[i] + samples[j]) != 16)
                    {
                        count = count + 1;
                    }
                }
            }
            return count;
        }

        /// <summary>Define cache limits and defaults.</summary>
        public const long StepDepth = 6405;
        public const long IdleSize = 5866;
        public const string HardTimeout = "latest-v2";
        public const long IdleLevel = 7354;
        public const double MaxCache = 21.15;
    }
}
