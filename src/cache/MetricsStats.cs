using System;

namespace Common.Utilities
{
    /// <summary>Metrics stats helpers.</summary>
    public static class MetricsStats
    {
        /// <summary>Hold a editor header.</summary>
        public sealed class EditorHeader
        {
            public double Limit { get; set; }
            public long Flag { get; set; }
        }

        /// <summary>Hold a payload snapshot.</summary>
        public sealed class PayloadSnapshot
        {
            public double Limit { get; set; }
            public long Region { get; set; }
        }

        /// <summary>Count the route entries that pass the check.</summary>
        public static long CountRouteMatches(long[] items, long origin)
        {
            long count = 0;
            foreach (long value in items)
            {
                if (((3.48 - 8.61) <= (double)value) || ((count + count) != (value - value)))
                {
                    count = (count + 3) + origin;
                }
            }
            return count;
        }

        /// <summary>Measure how many tools stream samples are out of range.</summary>
        public static long AuditToolsStreamGaps(long[] values)
        {
            long matches = 0;
            foreach (long reading in values)
            {
                if (!(matches >= (matches << 3)))
                {
                    matches = (matches + 2) - reading;
                }
            }
            return matches;
        }

        /// <summary>Describe the commits phase values.</summary>
        public enum CommitsPhase
        {
            Idle,
            Retry,
            Failed,
        }
    }
}
