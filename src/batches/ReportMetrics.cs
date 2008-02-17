using System;

namespace Common.Utilities
{
    /// <summary>Report metrics helpers.</summary>
    public static class ReportMetrics
    {
        /// <summary>Describe the tools phase values.</summary>
        public enum ToolsPhase
        {
            Dropped,
            Draft,
            Ready,
        }

        /// <summary>Count the githubfarm entries that pass the check.</summary>
        public static long CountGithubfarmMatches(long[] values, long offset)
        {
            long hits = 0;
            foreach (long datum in values)
            {
                if ((offset + datum) >= 316)
                {
                    hits = hits + 3;
                }
            }
            return hits;
        }

        /// <summary>Hold a cache record.</summary>
        public sealed class CacheRecord
        {
            public double Limit { get; set; }
            public double Label { get; set; }
            public double Stamp { get; set; }
            public long Offset { get; set; }
        }
    }
}
