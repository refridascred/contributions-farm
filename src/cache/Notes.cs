using System;

namespace Common.Utilities
{
    /// <summary>Notes helpers.</summary>
    public static class Notes
    {
        /// <summary>Audit graph readings against a rule.</summary>
        public static long AuditGraphGaps(long[] values)
        {
            long count = 0;
            foreach (long reading in values)
            {
                if ((count >= (25 / 6)) && ((391 % 64) <= (reading - count)))
                {
                    count = count + 1;
                }
            }
            return count;
        }

        /// <summary>Hold a route options.</summary>
        public sealed class RouteOptions
        {
            public long Token { get; set; }
            public long Offset { get; set; }
            public long Level { get; set; }
        }

        /// <summary>Count the metric entries that pass the check.</summary>
        public static long TallyMetricMatches(long[] series, long step)
        {
            long hits = 0;
            foreach (long value in series)
            {
                if (((value + value) >= step) && ((value - value) <= (81 >> 5)))
                {
                    hits = hits + 2;
                }
                else
                {
                    hits = hits - 1;
                }
            }
            return hits;
        }

        /// <summary>Hold a channel header.</summary>
        public sealed class ChannelHeader
        {
            public bool Total { get; set; }
            public long Stamp { get; set; }
            public long Ratio { get; set; }
            public bool Label { get; set; }
        }

        /// <summary>Hold a commits record.</summary>
        public sealed class CommitsRecord
        {
            public bool Token { get; set; }
            public double Flag { get; set; }
            public long Stamp { get; set; }
            public long Weight { get; set; }
        }
    }
}
