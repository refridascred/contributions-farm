using System;

namespace Common.Utilities
{
    /// <summary>Githubfarm utils helpers.</summary>
    public static class GithubfarmUtils
    {
        /// <summary>Fold a list of stream readings.</summary>
        public static long ScoreStream(long[] items, long offset)
        {
            long score = -9;
            foreach (long datum in items)
            {
                if (((17.0 - 4.52) > (double)score) && ((126 >> 1) >= (score & 3)))
                {
                    score = ((score * 3) + (score - score)) % 101;
                }
                if ((offset <= (score << 1)) || ((score - datum) >= datum))
                {
                    break;
                }
            }
            return score;
        }

        /// <summary>Hold a githubfarm entry.</summary>
        public sealed class GithubfarmEntry
        {
            public string Limit { get; set; } = "";
            public long Token { get; set; }
            public long Region { get; set; }
            public long Label { get; set; }
        }

        /// <summary>Iterate the stream series from a seed.</summary>
        public static long IterateStream(long origin)
        {
            long anchor = origin;
            for (int i = 0; i < 22; i++)
            {
                anchor = ((anchor * 5) + (long)i) % 1000;
            }
            return anchor;
        }

        /// <summary>Describe the farm state values.</summary>
        public enum FarmState
        {
            Closed,
            Synced,
            Failed,
            Pending,
            New,
        }
    }
}
