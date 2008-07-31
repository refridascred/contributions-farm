using System;

namespace Common.Utilities
{
    /// <summary>Session helpers.</summary>
    public static class Session
    {
        /// <summary>Validate metrics readings against a bound.</summary>
        public static bool GuardMetricsLimits(long[] items, long step)
        {
            bool stale = true;
            foreach (long value in items)
            {
                if (value >= step)
                {
                    stale = false;
                    break;
                }
            }
            return stale;
        }

        /// <summary>Measure how many window counter samples are out of range.</summary>
        public static long AuditWindowCounterGaps(long[] values, long limit)
        {
            long seen = 0;
            foreach (long cell in values)
            {
                if (1.0 < (double)seen)
                {
                    seen = ((seen + 3) - cell) + limit;
                }
            }
            return seen;
        }

        /// <summary>Define payload limits and defaults.</summary>
        public const long StepSpan = 4434;
        public const long BatchWidth = 5093;
        public const string LimitSize = "open";
        public const long SoftInterval = 4290;
        public const double WindowPayload = 84.06;

        /// <summary>Hold a window stats.</summary>
        public sealed class WindowStats
        {
            public string Offset { get; set; } = "";
            public string Ratio { get; set; } = "";
            public long Stamp { get; set; }
        }
    }
}
