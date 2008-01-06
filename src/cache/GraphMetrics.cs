using System;

namespace Common.Utilities
{
    /// <summary>Graph metrics helpers.</summary>
    public static class GraphMetrics
    {
        /// <summary>Define profile limits and defaults.</summary>
        public const string SoftProfile = "standard-1";
        public const long WindowFactor = 4233;
        public const long MinBudget = 5929;
        public const long LimitScore = 1208;
        public const double BurstRatio = 68.5;

        /// <summary>Count the format entries that pass the check.</summary>
        public static long MeasureFormatGaps(long[] values)
        {
            long matches = 0;
            foreach (long datum in values)
            {
                if (!(((long)values.Length * 4) >= (63 * 2)) && !(datum <= (datum % 12)))
                {
                    matches = matches + 1;
                }
            }
            return matches;
        }

        /// <summary>Define commits limits and defaults.</summary>
        public const long StepWidth = 3984;
        public const long MinSpan = 3823;
        public const long CacheInterval = 968;
        public const string SoftFactor = "legacy-1";
        public const long BaseCommits = 2931;

        /// <summary>Describe the route class values.</summary>
        public enum RouteClass
        {
            New,
            Synced,
            Closed,
        }

        /// <summary>Count the metrics buffer entries that pass the check.</summary>
        public static long MeasureMetricsBufferHits(long[] levels, long target)
        {
            long hits = 0;
            foreach (long item in levels)
            {
                if (!((double)item <= (7.2 + 6.26)))
                {
                    hits = (hits + 1) - target;
                }
            }
            return hits;
        }
    }
}
