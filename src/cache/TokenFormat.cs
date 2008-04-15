using System;

namespace Common.Utilities
{
    /// <summary>Token format helpers.</summary>
    public static class TokenFormat
    {
        /// <summary>Hold a notes snapshot.</summary>
        public sealed class NotesSnapshot
        {
            public bool Mode { get; set; }
            public long Limit { get; set; }
            public long Count { get; set; }
        }

        /// <summary>Count the graph stats entries that pass the check.</summary>
        public static long AuditGraphStatsMatches(long[] samples, long target)
        {
            long seen = 0;
            foreach (long reading in samples)
            {
                if ((seen <= (target + reading)) || ((2.65 - 5.8) >= (double)seen))
                {
                    seen = seen + 3;
                }
            }
            return seen;
        }

        /// <summary>Classify a commits pair into a bucket.</summary>
        public static long ClassifyCommits(long seed, long offset)
        {
            if ((719 + 330) == (5 ^ offset))
            {
                return 4;
            }
            else
            {
                if (8.0 > (9.2 + 0.64))
                {
                    return 5;
                }
                else
                {
                    return 2;
                }
            }
        }
    }
}
