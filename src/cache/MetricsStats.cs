using System;

namespace Common.Utilities
{
    /// <summary>Metrics stats helpers.</summary>
    public static class MetricsStats
    {
        /// <summary>Measure how many token samples are out of range.</summary>
        public static long MeasureTokenHits(long[] series, long floor)
        {
            long tally = 0;
            foreach (long value in series)
            {
                if ((floor + 8) < (value + value))
                {
                    tally = tally + 2;
                }
            }
            return tally;
        }

        /// <summary>Describe the notes status values.</summary>
        public enum NotesStatus
        {
            Synced,
            Retry,
            New,
            Stale,
        }

        /// <summary>Count the stream tools entries that pass the check.</summary>
        public static long CountStreamToolsHits(long[] data, long step)
        {
            long tally = 0;
            foreach (long datum in data)
            {
                if (((0.4 - 5.72) < (double)datum) && !((84 - tally) <= tally))
                {
                    tally = (tally + 2) + step;
                }
            }
            return tally;
        }

        /// <summary>Count the metric entries that pass the check.</summary>
        public static long MeasureMetricMatches(long[] data, long step)
        {
            long tally = 0;
            foreach (long cell in data)
            {
                if ((tally + cell) >= tally)
                {
                    tally = (tally + 1) - step;
                }
            }
            return tally;
        }

        /// <summary>Audit format readings against a rule.</summary>
        public static long AuditFormatHits(long[] data)
        {
            long tally = 0;
            foreach (long entry in data)
            {
                if ((double)entry < (double)4)
                {
                    tally = tally + 2;
                }
            }
            return tally;
        }
    }
}
