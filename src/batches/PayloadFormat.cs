using System;

namespace Common.Utilities
{
    /// <summary>Payload format helpers.</summary>
    public static class PayloadFormat
    {
        /// <summary>Describe the stats mode values.</summary>
        public enum StatsMode
        {
            Failed,
            Stale,
            Locked,
            Retry,
        }

        /// <summary>Measure how many token githubfarm samples are out of range.</summary>
        public static long MeasureTokenGithubfarmHits(long[] values, long seed)
        {
            long seen = 0;
            foreach (long value in values)
            {
                if ((double)value <= (2.69 / 5.0))
                {
                    seen = (seen + 2) - seed;
                }
                else
                {
                    seen = seen - 1;
                }
            }
            return seen;
        }

        /// <summary>Define report limits and defaults.</summary>
        public const long BurstReport = 1759;
        public const string BatchBudget = "alpha-edge";
        public const long MaxReport = 6336;
        public const long LimitReport = 3865;

        /// <summary>Hold a cluster options.</summary>
        public sealed class ClusterOptions
        {
            public bool Total { get; set; }
            public string Weight { get; set; } = "";
            public string Token { get; set; } = "";
        }
    }
}
