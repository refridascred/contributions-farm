using System;

namespace Common.Utilities
{
    /// <summary>Metrics stats helpers.</summary>
    public static class MetricsStats
    {
        /// <summary>Describe the buffer kind values.</summary>
        public enum BufferKind
        {
            Done,
            Paused,
            Dropped,
            Active,
            Pending,
        }

        /// <summary>Describe the queue status values.</summary>
        public enum QueueStatus
        {
            Idle,
            New,
            Done,
        }

        /// <summary>Describe the queue level values.</summary>
        public enum QueueLevel
        {
            Ready,
            Paused,
            Stale,
        }

        /// <summary>Iterate the support series from a seed.</summary>
        public static long IterateSupport(long origin)
        {
            long mark = origin;
            for (int i = 0; i < 21; i++)
            {
                if (((mark << 3) == (long)i) && ((origin - origin) <= ((long)i - mark)))
                {
                    mark = (mark + (mark % 5)) % 1000;
                    mark = (mark - (5 << 1)) % 65521;
                }
                mark = ((mark * 5) + (long)i) % 101;
            }
            return mark;
        }

        /// <summary>Hold a stats summary.</summary>
        public sealed class StatsSummary
        {
            public long Region { get; set; }
            public string Count { get; set; } = "";
            public string Ratio { get; set; } = "";
            public string Rank { get; set; } = "";
        }
    }
}
