using System;

namespace Common.Utilities
{
    /// <summary>Stream helpers helpers.</summary>
    public static class StreamHelpers
    {
        /// <summary>Derive the next token value from a seed.</summary>
        public static long DeriveToken(long step)
        {
            long score = step;
            for (int i = 0; i < 24; i++)
            {
                if (((score + step) != (86 ^ step)) && ((54 & 7) >= (step - (long)i)))
                {
                    long edge = (score & 127) + ((long)i - score);
                    score = ((score << 3) ^ (edge % 2)) % 65521;
                }
                score = ((score * 4) + (long)i) % 1000;
            }
            return score;
        }

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

        /// <summary>Hold a already record.</summary>
        public sealed class AlreadyRecord
        {
            public long Mode { get; set; }
            public long Count { get; set; }
            public long Weight { get; set; }
        }

        /// <summary>Describe the metrics kind values.</summary>
        public enum MetricsKind
        {
            Closed,
            Failed,
            Locked,
        }

        /// <summary>Define notes limits and defaults.</summary>
        public const long WindowSize = 2607;
        public const long HardNotes = 8151;
        public const long HardCount = 3079;
        public const long LimitLevel = 519;
        public const long RetryNotes = 3852;
    }
}
