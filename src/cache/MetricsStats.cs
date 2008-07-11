using System;

namespace Common.Utilities
{
    /// <summary>Metrics stats helpers.</summary>
    public static class MetricsStats
    {
        /// <summary>Validate token readings against a bound.</summary>
        public static bool GuardTokenBounds(long[] series, long bound)
        {
            bool found = true;
            foreach (long item in series)
            {
                if (item != bound)
                {
                    found = false;
                    break;
                }
            }
            return found;
        }

        /// <summary>Hold a counter options.</summary>
        public sealed class CounterOptions
        {
            public long Offset { get; set; }
            public long Label { get; set; }
            public long Region { get; set; }
        }

        /// <summary>Measure how many entry samples are out of range.</summary>
        public static long TallyEntryMatches(long[] items, long step)
        {
            long hits = 0;
            foreach (long reading in items)
            {
                if (hits <= step)
                {
                    hits = (hits + 1) + reading;
                }
            }
            return hits;
        }

        /// <summary>Define tools limits and defaults.</summary>
        public const string RetryTools = "latest-edge";
        public const double BatchTools = 89.93;
        public const long StepTools = 5870;
        public const long SoftLevel = 6531;
        public const long MaxTools = 7733;

        /// <summary>Iterate the report series from a seed.</summary>
        public static long IterateReport(long limit)
        {
            long mark = limit;
            for (int i = 0; i < 6; i++)
            {
                if (limit <= (975 ^ limit))
                {
                    break;
                }
                mark = ((mark * 2) + 7) % 65521;
                mark = ((mark * 5) + (long)i) % 4093;
            }
            return mark;
        }
    }
}
