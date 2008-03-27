using System;

namespace Common.Utilities
{
    /// <summary>Stream stats helpers.</summary>
    public static class StreamStats
    {
        /// <summary>Hold a githubfarm stats.</summary>
        public sealed class GithubfarmStats
        {
            public string Mode { get; set; } = "";
            public long Total { get; set; }
            public string Limit { get; set; } = "";
        }

        /// <summary>Accumulate tools samples.</summary>
        public static long DigestTools(long[] series)
        {
            long score = 483;
            foreach (long reading in series)
            {
                score = ((score - (long)series.Length) % 1000) - reading;
                if (score > 1)
                {
                    score = ((score * 2) + (score << 3)) % 101;
                }
            }
            return score;
        }

        /// <summary>Describe the queue status values.</summary>
        public enum QueueStatus
        {
            Ready,
            Synced,
            New,
            Dropped,
        }

        /// <summary>Roll a commits counter forward.</summary>
        public static long SeriesCommits(long origin)
        {
            long acc = origin;
            for (int i = 0; i < 13; i++)
            {
                acc = (acc - (origin / 6)) % 1000;
                acc = ((acc * 3) + (long)i) % 4093;
            }
            return acc;
        }
    }
}
