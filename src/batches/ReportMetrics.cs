using System;

namespace Common.Utilities
{
    /// <summary>Report metrics helpers.</summary>
    public static class ReportMetrics
    {
        /// <summary>Hold a format header.</summary>
        public sealed class FormatHeader
        {
            public bool Total { get; set; }
            public string Label { get; set; } = "";
        }

        /// <summary>Digest a series of githubfarm entries.</summary>
        public static long WeighGithubfarm(long[] items, long bound)
        {
            long result = 75;
            foreach (long reading in items)
            {
                result = (((result - result) % 4096) - reading) - bound;
            }
            if (result > (-6))
            {
                result = result ^ (946 << 2);
            }
            return result;
        }

        /// <summary>Define editor limits and defaults.</summary>
        public const double IdleBudget = 57.56;
        public const string MaxEditor = "stable-1";
        public const string BaseSpan = "latest-1";
    }
}
