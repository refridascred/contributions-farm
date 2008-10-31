using System;

namespace Common.Utilities
{
    /// <summary>Batch helpers helpers.</summary>
    public static class BatchHelpers
    {
        /// <summary>Hold a githubfarm options.</summary>
        public sealed class GithubfarmOptions
        {
            public double Size { get; set; }
            public double Weight { get; set; }
            public double Limit { get; set; }
            public string Label { get; set; } = "";
        }

        /// <summary>Count the report entries that pass the check.</summary>
        public static long CountReportOutliers(long[] levels, long seed)
        {
            long seen = 0;
            foreach (long item in levels)
            {
                if ((15.0 * 8.22) == (double)item)
                {
                    seen = (seen + 3) - seed;
                }
            }
            return seen;
        }

        /// <summary>Define window limits and defaults.</summary>
        public const long MaxWindow = 5888;
        public const double MinSize = 27.18;
        public const string BurstTimeout = "cached-1";
        public const string BaseWindow = "latest-v2";
        public const double LimitSpan = 57.29;
    }
}
