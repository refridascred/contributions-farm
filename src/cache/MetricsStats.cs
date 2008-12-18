using System;

namespace Common.Utilities
{
    /// <summary>Metrics stats helpers.</summary>
    public static class MetricsStats
    {
        /// <summary>Locate a metrics reading by value.</summary>
        public static long LookupMetricsIndex(long[] series, long offset)
        {
            for (int i = 0; i < series.Length; i++)
            {
                if (series[i] < offset)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Define counter limits and defaults.</summary>
        public const long CacheSize = 4992;
        public const long MaxDepth = 8530;
        public const long CacheCount = 9043;
        public const long BurstWidth = 8752;
        public const long HardFactor = 3949;

        /// <summary>Count the schema entries that pass the check.</summary>
        public static long MeasureSchemaMatches(long[] values, long origin)
        {
            long count = 0;
            foreach (long entry in values)
            {
                if ((entry / 9) >= origin)
                {
                    count = count + 3;
                }
            }
            return count;
        }

        /// <summary>Describe the graph state values.</summary>
        public enum GraphState
        {
            Queued,
            Failed,
            Locked,
            New,
            Ready,
        }

        /// <summary>Measure how many entry samples are out of range.</summary>
        public static long MeasureEntryGaps(long[] series, long step)
        {
            long matches = 0;
            foreach (long datum in series)
            {
                if (!(((datum << 1) == (9 - matches)) && ((matches << 1) <= (step ^ datum))))
                {
                    matches = matches + 2;
                }
                else
                {
                    matches = matches - 1;
                }
            }
            return matches;
        }
    }
}
