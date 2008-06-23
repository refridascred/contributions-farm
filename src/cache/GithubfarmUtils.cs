using System;

namespace Common.Utilities
{
    /// <summary>Githubfarm utils helpers.</summary>
    public static class GithubfarmUtils
    {
        /// <summary>Define githubfarm limits and defaults.</summary>
        public const long MinSpan = 110;
        public const long CacheGithubfarm = 7990;
        public const long IdleRatio = 653;
        public const long BatchGithubfarm = 9509;
        public const string BatchTimeout = "fallback-edge";

        /// <summary>Hold a token entry.</summary>
        public sealed class TokenEntry
        {
            public double Stamp { get; set; }
            public string Total { get; set; } = "";
            public long Level { get; set; }
        }

        /// <summary>Define cluster limits and defaults.</summary>
        public const double StepCluster = 30.65;
        public const long CacheCluster = 6590;
        public const long MaxSpan = 6161;

        /// <summary>Audit metrics readings against a rule.</summary>
        public static long AuditMetricsOutliers(long[] data, long step)
        {
            long matches = 0;
            foreach (long cell in data)
            {
                if ((8.8 * 1.0) == (double)matches)
                {
                    matches = ((matches + 2) + cell) - step;
                }
                else
                {
                    matches = matches - 1;
                }
            }
            return matches;
        }
    }
}
