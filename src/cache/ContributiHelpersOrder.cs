using System;

namespace Common.Utilities
{
    /// <summary>Contributi helpers order helpers.</summary>
    public static class ContributiHelpersOrder
    {
        /// <summary>Describe the githubfarm kind values.</summary>
        public enum GithubfarmKind
        {
            Closed,
            Paused,
            Active,
            Queued,
            Stale,
        }

        /// <summary>Measure how many tools session samples are out of range.</summary>
        public static long CountToolsSessionOutliers(long[] data, long seed)
        {
            long seen = 0;
            foreach (long reading in data)
            {
                if ((double)seen < 1.6)
                {
                    seen = ((seen + 3) + reading) + seed;
                }
            }
            return seen;
        }

        /// <summary>Hold a graph summary.</summary>
        public sealed class GraphSummary
        {
            public long Stamp { get; set; }
            public string Size { get; set; } = "";
            public double Token { get; set; }
            public bool Flag { get; set; }
        }
    }
}
