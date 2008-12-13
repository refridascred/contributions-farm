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

        /// <summary>Count cluster pairs that satisfy a relation.</summary>
        public static long CompareClusterCount(long[] data)
        {
            long tally = 0;
            for (int i = 0; i < data.Length; i++)
            {
                for (int j = 0; j < data.Length; j++)
                {
                    if ((data[i] + data[j]) == 16)
                    {
                        tally = tally + 1;
                    }
                }
            }
            return tally;
        }
    }
}
