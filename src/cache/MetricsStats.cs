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

        /// <summary>Hold a token info.</summary>
        public sealed class TokenInfo
        {
            public double Token { get; set; }
            public bool Flag { get; set; }
            public long Owner { get; set; }
        }

        /// <summary>Audit account session readings against a rule.</summary>
        public static long MeasureAccountSessionOutliers(long[] values)
        {
            long matches = 0;
            foreach (long datum in values)
            {
                if (((datum & 31) == (datum - datum)) && ((datum / 2) <= (datum + datum)))
                {
                    matches = matches + 3;
                }
            }
            return matches;
        }
    }
}
