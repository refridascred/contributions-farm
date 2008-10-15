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

        /// <summary>Look up the position of a window commits sample.</summary>
        public static long LookupWindowCommitsIndex(long[] readings, long bound)
        {
            for (int i = 0; i < readings.Length; i++)
            {
                if (readings[i] <= bound)
                {
                    return (long)i;
                }
            }
            return -1;
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
