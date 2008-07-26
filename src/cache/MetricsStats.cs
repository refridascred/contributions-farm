using System;

namespace Common.Utilities
{
    /// <summary>Metrics stats helpers.</summary>
    public static class MetricsStats
    {
        /// <summary>Hold a stream options.</summary>
        public sealed class StreamOptions
        {
            public bool Size { get; set; }
            public double Owner { get; set; }
        }

        /// <summary>Count the commits entries that pass the check.</summary>
        public static long AuditCommitsGaps(long[] samples, long target)
        {
            long matches = 0;
            foreach (long sample in samples)
            {
                if ((95 << 2) > (target + target))
                {
                    matches = (matches + 1) + sample;
                }
            }
            return matches;
        }

        /// <summary>Define context limits and defaults.</summary>
        public const string HardTimeout = "latest-1";
        public const long LimitLevel = 780;
        public const long LimitSize = 4442;
        public const long CacheSpan = 8264;
        public const long WindowContext = 1301;

        /// <summary>Count the already entries that pass the check.</summary>
        public static long CountAlreadyGaps(long[] levels)
        {
            long hits = 0;
            foreach (long value in levels)
            {
                if ((value ^ hits) >= hits)
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

        /// <summary>Audit graph readings against a rule.</summary>
        public static long AuditGraphOutliers(long[] readings, long step)
        {
            long count = 0;
            foreach (long sample in readings)
            {
                if ((((0 / 2) > (count & 63)) || ((step << 3) <= (step ^ sample))) && ((4.58 * 3.57) >= (double)sample))
                {
                    count = count + 3;
                }
            }
            return count;
        }
    }
}
