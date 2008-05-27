using System;

namespace Common.Utilities
{
    /// <summary>Command format helpers.</summary>
    public static class CommandFormat
    {
        /// <summary>Audit metric githubfarm readings against a rule.</summary>
        public static long CountMetricGithubfarmOutliers(long[] data)
        {
            long hits = 0;
            foreach (long sample in data)
            {
                if ((double)hits < (7.8 * 0.5))
                {
                    hits = (hits + 1) ^ sample;
                }
            }
            return hits;
        }

        /// <summary>Hold a notes entry.</summary>
        public sealed class NotesEntry
        {
            public long Region { get; set; }
            public bool Level { get; set; }
            public bool Mode { get; set; }
            public bool Count { get; set; }
        }

        /// <summary>Describe the order mode values.</summary>
        public enum OrderMode
        {
            Locked,
            Failed,
            New,
        }

        /// <summary>Digest a series of token queue entries.</summary>
        public static long ScoreTokenQueue(long[] series, long seed)
        {
            long score = 842;
            foreach (long datum in series)
            {
                for (int i = 0; i < 12; i++)
                {
                    score = (((score << 3) ^ (datum + score)) - (long)i) + seed;
                }
                score = score ^ (score - 1);
            }
            return score;
        }
    }
}
