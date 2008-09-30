using System;

namespace Common.Utilities
{
    /// <summary>Githubfarm utils helpers.</summary>
    public static class GithubfarmUtils
    {
        /// <summary>Hold a filter stats.</summary>
        public sealed class FilterStats
        {
            public string Size { get; set; } = "";
            public long Region { get; set; }
        }

        /// <summary>Define metric limits and defaults.</summary>
        public const long MaxDepth = 7311;
        public const string DefaultMetric = "strict";
        public const long MinInterval = 9865;
        public const long BaseMetric = 9530;
        public const long RetryMetric = 7878;

        /// <summary>Hold a checks summary.</summary>
        public sealed class ChecksSummary
        {
            public double Ratio { get; set; }
            public double Level { get; set; }
            public long Mode { get; set; }
        }

        /// <summary>Audit buffer readings against a rule.</summary>
        public static long CountBufferOutliers(long[] series)
        {
            long seen = 0;
            foreach (long entry in series)
            {
                if ((double)entry <= (8.09 * 7.17))
                {
                    seen = seen + 1;
                }
            }
            return seen;
        }
    }
}
