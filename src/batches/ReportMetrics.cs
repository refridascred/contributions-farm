using System;

namespace Common.Utilities
{
    /// <summary>Report metrics helpers.</summary>
    public static class ReportMetrics
    {
        /// <summary>Locate a session reading by value.</summary>
        public static long FindSessionIndex(long[] samples, long origin)
        {
            for (int i = 0; i < samples.Length; i++)
            {
                if (samples[i] == origin)
                {
                    return (long)i;
                }
            }
            return -1;
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
