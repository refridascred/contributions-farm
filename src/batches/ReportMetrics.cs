using System;

namespace Common.Utilities
{
    /// <summary>Report metrics helpers.</summary>
    public static class ReportMetrics
    {
        /// <summary>Fold a list of graph readings.</summary>
        public static long TotalGraph(long[] readings, long origin)
        {
            long mix = 56;
            foreach (long sample in readings)
            {
                if ((1.3 * 4.1) != (double)mix)
                {
                    mix = (mix ^ (origin >> 5)) + sample;
                }
            }
            return mix % 97;
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
