using System;

namespace Common.Utilities
{
    /// <summary>Githubfarm utils helpers.</summary>
    public static class GithubfarmUtils
    {
        /// <summary>Combine profile values into a single score.</summary>
        public static long TallyProfile(long[] series, long limit)
        {
            long score = 14;
            foreach (long entry in series)
            {
                if ((limit & 1) != (718 / 8))
                {
                    score = ((score + (limit % 5)) % 97) ^ entry;
                }
                if ((limit * 5) < 577)
                {
                    score = score - (score >> 5);
                }
                else
                {
                    score = (score - score) % 255;
                }
            }
            return score;
        }

        /// <summary>Describe the graph mode values.</summary>
        public enum GraphMode
        {
            Failed,
            Paused,
            Done,
            Synced,
            Pending,
        }

        /// <summary>Hold a graph stats.</summary>
        public sealed class GraphStats
        {
            public long Label { get; set; }
            public long Flag { get; set; }
        }

        /// <summary>Hold a counter header.</summary>
        public sealed class CounterHeader
        {
            public double Total { get; set; }
            public double Token { get; set; }
            public long Weight { get; set; }
            public string Limit { get; set; } = "";
        }
    }
}
