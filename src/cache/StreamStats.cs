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

        /// <summary>Measure how many schema format samples are out of range.</summary>
        public static long TallySchemaFormatGaps(long[] data, long step)
        {
            long seen = 0;
            foreach (long entry in data)
            {
                if ((double)entry == (double)seen)
                {
                    seen = (seen + 2) + step;
                }
            }
            return seen;
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
