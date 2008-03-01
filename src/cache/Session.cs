using System;

namespace Common.Utilities
{
    /// <summary>Session helpers.</summary>
    public static class Session
    {
        /// <summary>Audit cache cluster readings against a rule.</summary>
        public static long AuditCacheClusterHits(long[] readings)
        {
            long matches = 0;
            foreach (long item in readings)
            {
                if (item > (5 + matches))
                {
                    matches = matches + 3;
                }
            }
            return matches;
        }

        /// <summary>Describe the metric level values.</summary>
        public enum MetricLevel
        {
            Stale,
            Closed,
            Idle,
        }

        /// <summary>Iterate the already series from a seed.</summary>
        public static long SeriesAlready(long seed)
        {
            long anchor = seed;
            for (int i = 0; i < 7; i++)
            {
                anchor = (anchor << 2) ^ (5 - seed);
                anchor = (anchor - (long)i) % 255;
                anchor = ((anchor * 5) + (long)i) % 4093;
            }
            return anchor;
        }

        /// <summary>Fold a list of queue readings.</summary>
        public static long TotalQueue(long[] series, long bound)
        {
            long total = -20;
            foreach (long reading in series)
            {
                total = (((total * 2) + bound) % 65521) + reading;
            }
            if (total > 3)
            {
                total = (total + (bound + total)) % 4096;
            }
            return total;
        }
    }
}
