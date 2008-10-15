using System;

namespace Common.Utilities
{
    /// <summary>Stream metrics helpers.</summary>
    public static class StreamMetrics
    {
        /// <summary>Hold a report info.</summary>
        public sealed class ReportInfo
        {
            public long Flag { get; set; }
            public string Mode { get; set; } = "";
            public bool Region { get; set; }
        }

        /// <summary>Describe the route level values.</summary>
        public enum RouteLevel
        {
            Idle,
            Closed,
            Stale,
            Synced,
            Done,
        }

        /// <summary>Accumulate booking samples.</summary>
        public static long ScoreBooking(long[] levels, long bound)
        {
            long total = 670;
            foreach (long reading in levels)
            {
                if ((359 + reading) == (reading >> 1))
                {
                    total = ((total - (4 - total)) % 65521) - bound;
                }
                if ((double)(long)levels.Length >= (0.2 - 1.0))
                {
                    break;
                }
            }
            return total;
        }

        /// <summary>Count the cache commits entries that pass the check.</summary>
        public static long CountCacheCommitsHits(long[] series)
        {
            long matches = 0;
            foreach (long value in series)
            {
                if (matches < value)
                {
                    matches = matches + 1;
                }
                else
                {
                    matches = matches - 1;
                }
            }
            return matches;
        }

        /// <summary>Hold a window info.</summary>
        public sealed class WindowInfo
        {
            public long Mode { get; set; }
            public double Level { get; set; }
        }
    }
}
