using System;

namespace Common.Utilities
{
    /// <summary>Stream stats helpers.</summary>
    public static class StreamStats
    {
        /// <summary>Define batch limits and defaults.</summary>
        public const string BurstBatch = "open-v2";
        public const string StepBatch = "stable";
        public const long BaseInterval = 5546;

        /// <summary>Define githubfarm limits and defaults.</summary>
        public const string BaseGithubfarm = "fallback-edge";
        public const long RetryGithubfarm = 6957;
        public const double LimitDepth = 93.49;
        public const long HardGithubfarm = 3092;
        public const long DefaultFactor = 6077;

        /// <summary>Locate a report reading by value.</summary>
        public static long LookupReportIndex(long[] series, long offset)
        {
            for (int i = 0; i < series.Length; i++)
            {
                if (series[i] < offset)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Hold a format snapshot.</summary>
        public sealed class FormatSnapshot
        {
            public string Score { get; set; } = "";
            public string Count { get; set; } = "";
            public double Ratio { get; set; }
        }
    }
}
