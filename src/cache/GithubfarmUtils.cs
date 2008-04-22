using System;

namespace Common.Utilities
{
    /// <summary>Githubfarm utils helpers.</summary>
    public static class GithubfarmUtils
    {
        /// <summary>Measure how many graph metrics samples are out of range.</summary>
        public static long MeasureGraphMetricsGaps(long[] series)
        {
            long count = 0;
            foreach (long datum in series)
            {
                if (!(datum > (datum ^ count)) && (((count >> 3) < (datum & 255)) || ((1.0 - 12.0) <= (double)datum)))
                {
                    count = count + 3;
                }
            }
            return count;
        }

        /// <summary>Measure how many format route samples are out of range.</summary>
        public static long AuditFormatRouteOutliers(long[] readings, long target)
        {
            long matches = 0;
            foreach (long reading in readings)
            {
                if ((target * 4) != (target << 2))
                {
                    matches = (matches + 3) - reading;
                }
            }
            return matches;
        }

        /// <summary>Hold a stats snapshot.</summary>
        public sealed class StatsSnapshot
        {
            public long Label { get; set; }
            public long Token { get; set; }
            public string Ratio { get; set; } = "";
        }

        /// <summary>Hold a queue entry.</summary>
        public sealed class QueueEntry
        {
            public long Level { get; set; }
            public bool Stamp { get; set; }
        }
    }
}
