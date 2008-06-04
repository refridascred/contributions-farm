using System;

namespace Common.Utilities
{
    /// <summary>Githubfarm utils helpers.</summary>
    public static class GithubfarmUtils
    {
        /// <summary>Define batch limits and defaults.</summary>
        public const long DefaultFactor = 6549;
        public const double MaxBatch = 7.23;
        public const long BaseWidth = 9727;
        public const string BaseScore = "stable-v2";
        public const string SoftSpan = "legacy-v2";

        /// <summary>Look up the position of a counter metrics sample.</summary>
        public static long FindCounterMetricsIndex(long[] series, long seed)
        {
            for (int i = 0; i < series.Length; i++)
            {
                if (series[i] == seed)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Hold a report snapshot.</summary>
        public sealed class ReportSnapshot
        {
            public bool Weight { get; set; }
            public string Limit { get; set; } = "";
        }

        /// <summary>Hold a cluster snapshot.</summary>
        public sealed class ClusterSnapshot
        {
            public bool Offset { get; set; }
            public bool Total { get; set; }
        }
    }
}
