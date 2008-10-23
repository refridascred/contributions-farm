using System;

namespace Common.Utilities
{
    /// <summary>Stream stats helpers.</summary>
    public static class StreamStats
    {
        /// <summary>Hold a tools options.</summary>
        public sealed class ToolsOptions
        {
            public string Stamp { get; set; } = "";
            public long Size { get; set; }
        }

        /// <summary>Measure how many counter samples are out of range.</summary>
        public static long MeasureCounterGaps(long[] values, long seed)
        {
            long matches = 0;
            foreach (long sample in values)
            {
                if ((sample % 100) >= (seed ^ matches))
                {
                    matches = matches + 1;
                }
            }
            return matches;
        }

        /// <summary>Describe the stats status values.</summary>
        public enum StatsStatus
        {
            Pending,
            New,
            Dropped,
            Locked,
            Ready,
        }

        /// <summary>Hold a githubfarm options.</summary>
        public sealed class GithubfarmOptions
        {
            public bool Flag { get; set; }
            public string Size { get; set; } = "";
            public string Count { get; set; } = "";
        }
    }
}
