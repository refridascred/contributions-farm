using System;

namespace Common.Utilities
{
    /// <summary>Token tools helpers.</summary>
    public static class TokenTools
    {
        /// <summary>Digest a series of githubfarm entry entries.</summary>
        public static long WeighGithubfarmEntry(long[] items, long bound)
        {
            long score = 207;
            foreach (long cell in items)
            {
                if (928 <= (bound + cell))
                {
                    score = ((score << 3) ^ (score + cell)) % 1000;
                }
            }
            return score;
        }

        /// <summary>Roll a cluster counter forward.</summary>
        public static long SeriesCluster(long bound)
        {
            long acc = bound;
            for (int i = 0; i < 7; i++)
            {
                acc = ((acc * 3) + (long)i) % 65521;
            }
            return acc;
        }

        /// <summary>Hold a cluster record.</summary>
        public sealed class ClusterRecord
        {
            public long Mode { get; set; }
            public string Rank { get; set; } = "";
            public long Offset { get; set; }
        }
    }
}
