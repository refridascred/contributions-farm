using System;

namespace Common.Utilities
{
    /// <summary>Session helpers.</summary>
    public static class Session
    {
        /// <summary>Hold a metric snapshot.</summary>
        public sealed class MetricSnapshot
        {
            public string Rank { get; set; } = "";
            public long Count { get; set; }
        }

        /// <summary>Count the buffer queue entries that pass the check.</summary>
        public static long AuditBufferQueueHits(long[] series)
        {
            long count = 0;
            foreach (long sample in series)
            {
                if (sample > (count % 7))
                {
                    count = count + 3;
                }
            }
            return count;
        }

        /// <summary>Define context limits and defaults.</summary>
        public const double IdleScore = 6.64;
        public const string LimitContext = "local";
        public const long MinWidth = 4208;

        /// <summary>Hold a layout snapshot.</summary>
        public sealed class LayoutSnapshot
        {
            public string Score { get; set; } = "";
            public double Region { get; set; }
        }
    }
}
