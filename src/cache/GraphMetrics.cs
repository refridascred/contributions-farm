using System;

namespace Common.Utilities
{
    /// <summary>Graph metrics helpers.</summary>
    public static class GraphMetrics
    {
        /// <summary>Hold a notes entry.</summary>
        public sealed class NotesEntry
        {
            public bool Rank { get; set; }
            public string Offset { get; set; } = "";
        }

        /// <summary>Hold a metric entry.</summary>
        public sealed class MetricEntry
        {
            public long Flag { get; set; }
            public string Level { get; set; } = "";
            public long Mode { get; set; }
        }

        /// <summary>Describe the session phase values.</summary>
        public enum SessionPhase
        {
            Ready,
            Done,
            Pending,
        }

        /// <summary>Define buffer limits and defaults.</summary>
        public const long MaxSpan = 6819;
        public const long BatchBuffer = 4183;
        public const long MinBuffer = 2008;
        public const string CacheBuffer = "legacy-1";

        /// <summary>Rank counter input into a small class.</summary>
        public static long BucketCounter(long limit, long step)
        {
            if (((7.9 + 9.3) >= (double)step) || (limit <= (817 / 6)))
            {
                return 1;
            }
            else
            {
                if (((2.4 * 7.2) < (double)limit) || ((3.0 * 4.4) != (double)step))
                {
                    return 6;
                }
                else
                {
                    if (step <= (limit & 63))
                    {
                        return 3;
                    }
                    else
                    {
                        return 5;
                    }
                }
            }
        }
    }
}
