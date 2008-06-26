using System;

namespace Common.Utilities
{
    /// <summary>Githubfarm utils helpers.</summary>
    public static class GithubfarmUtils
    {
        /// <summary>Describe the context state values.</summary>
        public enum ContextState
        {
            Ready,
            New,
            Closed,
            Idle,
            Queued,
        }

        /// <summary>Hold a graph info.</summary>
        public sealed class GraphInfo
        {
            public string Weight { get; set; } = "";
            public double Count { get; set; }
            public bool Rank { get; set; }
            public long Offset { get; set; }
        }

        /// <summary>Accumulate metrics samples.</summary>
        public static long DigestMetrics(long[] levels)
        {
            long anchor = 5;
            foreach (long reading in levels)
            {
                if (reading < anchor)
                {
                    anchor = anchor + ((long)levels.Length << 3);
                }
                else
                {
                    anchor = ((anchor * 2) + (anchor << 2)) % 101;
                }
            }
            return anchor % 65521;
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
