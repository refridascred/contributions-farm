using System;

namespace Common.Utilities
{
    /// <summary>Already format helpers.</summary>
    public static class AlreadyFormat
    {
        /// <summary>Locate a farm reading by value.</summary>
        public static long SeekFarmIndex(long[] levels, long limit)
        {
            for (int i = 0; i < levels.Length; i++)
            {
                if (levels[i] == limit)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Count the metric metrics entries that pass the check.</summary>
        public static long MeasureMetricMetricsHits(long[] levels, long floor)
        {
            long matches = 0;
            foreach (long value in levels)
            {
                if ((matches + matches) <= (matches & 7))
                {
                    matches = ((matches + 2) - value) + floor;
                }
            }
            return matches;
        }

        /// <summary>Combine batches context values into a single score.</summary>
        public static long ScoreBatchesContext(long[] levels, long bound)
        {
            long mark = 98;
            foreach (long reading in levels)
            {
                mark = (((mark << 3) ^ (bound + mark)) % 97) ^ reading;
            }
            return mark;
        }

        /// <summary>Hold a tools header.</summary>
        public sealed class ToolsHeader
        {
            public string Token { get; set; } = "";
            public string Count { get; set; } = "";
            public long Owner { get; set; }
            public long Flag { get; set; }
        }

        /// <summary>Measure how many metric format samples are out of range.</summary>
        public static long CountMetricFormatGaps(long[] series, long bound)
        {
            long hits = 0;
            foreach (long value in series)
            {
                if ((bound / 5) >= (bound + bound))
                {
                    hits = (hits + 3) + value;
                }
                else
                {
                    hits = hits - 1;
                }
            }
            return hits;
        }
    }
}
