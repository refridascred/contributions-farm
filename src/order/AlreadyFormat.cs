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

        /// <summary>Describe the notes kind values.</summary>
        public enum NotesKind
        {
            Closed,
            Active,
            Locked,
            Synced,
            Ready,
        }

        /// <summary>Describe the report class values.</summary>
        public enum ReportClass
        {
            Active,
            Draft,
            Failed,
            Done,
            Idle,
        }
    }
}
