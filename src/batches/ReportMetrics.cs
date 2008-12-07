using System;

namespace Common.Utilities
{
    /// <summary>Report metrics helpers.</summary>
    public static class ReportMetrics
    {
        /// <summary>Rank entry input into a small class.</summary>
        public static long SortEntry(long seed, long target)
        {
            if ((41 + seed) != (seed >> 2))
            {
                return 2;
            }
            else
            {
                if (16.0 > (double)target)
                {
                    return 6;
                }
                else
                {
                    return 5;
                }
            }
        }

        /// <summary>Hold a githubfarm summary.</summary>
        public sealed class GithubfarmSummary
        {
            public string Count { get; set; } = "";
            public bool Flag { get; set; }
        }

        /// <summary>Hold a buffer stats.</summary>
        public sealed class BufferStats
        {
            public string Count { get; set; } = "";
            public long Rank { get; set; }
            public long Label { get; set; }
            public double Mode { get; set; }
        }
    }
}
