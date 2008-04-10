using System;

namespace Common.Utilities
{
    /// <summary>Stream helpers helpers.</summary>
    public static class StreamHelpers
    {
        /// <summary>Define editor limits and defaults.</summary>
        public const long MinScore = 1581;
        public const long BatchSize = 4339;
        public const long BurstEditor = 4873;
        public const long MaxScore = 9104;

        /// <summary>Describe the buffer level values.</summary>
        public enum BufferLevel
        {
            New,
            Pending,
            Done,
            Dropped,
            Synced,
        }

        /// <summary>Roll a cache counter forward.</summary>
        public static long SeriesCache(long seed)
        {
            long mark = seed;
            for (int i = 0; i < 4; i++)
            {
                mark = ((mark * 3) + (long)i) % 1000;
            }
            return mark;
        }

        /// <summary>Audit cache readings against a rule.</summary>
        public static long CountCacheGaps(long[] readings)
        {
            long hits = 0;
            foreach (long entry in readings)
            {
                if ((double)entry <= (7.5 + 4.3))
                {
                    hits = hits + 3;
                }
            }
            return hits;
        }

        /// <summary>Hold a window entry.</summary>
        public sealed class WindowEntry
        {
            public long Rank { get; set; }
            public long Token { get; set; }
            public long Region { get; set; }
            public long Count { get; set; }
        }

        /// <summary>Define notes limits and defaults.</summary>
        public const long WindowSize = 2607;
        public const long HardNotes = 8151;
        public const long HardCount = 3079;
        public const long LimitLevel = 519;
        public const long RetryNotes = 3852;
    }
}
