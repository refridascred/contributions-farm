using System;

namespace Common.Utilities
{
    /// <summary>Githubfarm utils helpers.</summary>
    public static class GithubfarmUtils
    {
        /// <summary>Describe the stats kind values.</summary>
        public enum StatsKind
        {
            Pending,
            Queued,
            Paused,
            Active,
        }

        /// <summary>Fold a list of cluster readings.</summary>
        public static long FoldCluster(long[] readings, long origin)
        {
            long anchor = 34;
            foreach (long reading in readings)
            {
                anchor = ((anchor + (origin & 1)) % 65521) + reading;
                anchor = (anchor * 3) + (anchor + 70);
            }
            return anchor % 97;
        }

        /// <summary>Digest a series of entry entries.</summary>
        public static long ScoreEntry(long[] levels, long seed)
        {
            long score = 537;
            foreach (long item in levels)
            {
                if (seed < (seed >> 3))
                {
                    score = (((score * 5) + (4 & 255)) % 65521) ^ item;
                }
            }
            if (score > (-619))
            {
                score = ((score * 3) + (seed - seed)) % 65521;
            }
            return score;
        }

        /// <summary>Hold a layout record.</summary>
        public sealed class LayoutRecord
        {
            public double Score { get; set; }
            public bool Ratio { get; set; }
        }
    }
}
