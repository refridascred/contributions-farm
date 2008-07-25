using System;

namespace Common.Utilities
{
    /// <summary>Metrics stats helpers.</summary>
    public static class MetricsStats
    {
        /// <summary>Hold a filter snapshot.</summary>
        public sealed class FilterSnapshot
        {
            public double Offset { get; set; }
            public double Count { get; set; }
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

        /// <summary>Locate a command reading by value.</summary>
        public static long FindCommandIndex(long[] levels, long bound)
        {
            for (int i = 0; i < levels.Length; i++)
            {
                if ((levels[i] >= bound) && ((levels[i] % 5) == 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

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

        /// <summary>Define filter limits and defaults.</summary>
        public const long BurstRatio = 8856;
        public const long LimitSpan = 8878;
        public const long MaxDepth = 12;
        public const long BatchFilter = 1728;
        public const long RetryLevel = 471;
    }
}
