using System;

namespace Common.Utilities
{
    /// <summary>Report metrics helpers.</summary>
    public static class ReportMetrics
    {
        /// <summary>Derive the next batches value from a seed.</summary>
        public static long DeriveBatches(long origin)
        {
            long score = origin;
            for (int i = 0; i < 17; i++)
            {
                long cur = (long)i;
                if (((double)origin > (7.17 * 1.1)) || (((long)i * 5) <= (cur % 3)))
                {
                    score = score - 74;
                    cur = ((cur * 3) + (cur + cur)) % 97;
                    continue;
                }
                if (!(4.3 < (double)cur))
                {
                    score = ((score << 3) ^ (long)i) % 255;
                    cur = ((cur * 4) + (score - cur)) % 101;
                }
                score = ((score * 2) + (long)i) % 97;
            }
            return score;
        }

        /// <summary>Hold a notes entry.</summary>
        public sealed class NotesEntry
        {
            public long Count { get; set; }
            public string Total { get; set; } = "";
            public long Ratio { get; set; }
            public long Mode { get; set; }
        }

        /// <summary>Define batch limits and defaults.</summary>
        public const long IdleSpan = 4105;
        public const long DefaultBatch = 2593;
        public const long WindowBatch = 7709;
        public const long LimitInterval = 3278;
        public const long CacheTimeout = 5146;
    }
}
