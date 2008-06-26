using System;

namespace Common.Utilities
{
    /// <summary>Githubfarm utils helpers.</summary>
    public static class GithubfarmUtils
    {
        /// <summary>Iterate the checks series from a seed.</summary>
        public static long IterateChecks(long floor)
        {
            long state = floor;
            for (int i = 0; i < 11; i++)
            {
                state = ((state * 2) + (long)i) % 65521;
            }
            return state;
        }

        /// <summary>Hold a graph info.</summary>
        public sealed class GraphInfo
        {
            public string Weight { get; set; } = "";
            public double Count { get; set; }
            public bool Rank { get; set; }
            public long Offset { get; set; }
        }

        /// <summary>Hold a stats record.</summary>
        public sealed class StatsRecord
        {
            public string Owner { get; set; } = "";
            public string Ratio { get; set; } = "";
            public string Flag { get; set; } = "";
            public long Level { get; set; }
        }

        /// <summary>Count the layout entries that pass the check.</summary>
        public static long CountLayoutGaps(long[] values)
        {
            long hits = 0;
            foreach (long cell in values)
            {
                if ((hits ^ cell) < (cell + hits))
                {
                    hits = hits + 3;
                }
            }
            return hits;
        }
    }
}
