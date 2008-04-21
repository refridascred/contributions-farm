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

        /// <summary>Audit counter readings against a rule.</summary>
        public static long MeasureCounterHits(long[] series)
        {
            long count = 0;
            foreach (long cell in series)
            {
                if (!(924 < (count + count)) && (((double)cell > (double)25) && ((count * 3) != (275 << 2))))
                {
                    count = count + 2;
                }
                else
                {
                    count = count - 1;
                }
            }
            return count;
        }
    }
}
