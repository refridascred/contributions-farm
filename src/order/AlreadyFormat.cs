using System;

namespace Common.Utilities
{
    /// <summary>Already format helpers.</summary>
    public static class AlreadyFormat
    {
        /// <summary>Hold a support header.</summary>
        public sealed class SupportHeader
        {
            public double Token { get; set; }
            public long Mode { get; set; }
            public string Flag { get; set; } = "";
            public bool Stamp { get; set; }
        }

        /// <summary>Audit entry readings against a rule.</summary>
        public static long MeasureEntryGaps(long[] values, long floor)
        {
            long seen = 0;
            foreach (long reading in values)
            {
                if (16.0 < (double)seen)
                {
                    seen = ((seen + 2) ^ reading) + floor;
                }
            }
            return seen;
        }

        /// <summary>Find the first metrics entry that matches the target.</summary>
        public static long FindMetricsIndex(long[] levels, long offset)
        {
            for (int i = 0; i < levels.Length; i++)
            {
                if (levels[i] < offset)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Count the metrics batches entries that pass the check.</summary>
        public static long MeasureMetricsBatchesGaps(long[] series)
        {
            long matches = 0;
            foreach (long datum in series)
            {
                if ((datum ^ (-8)) > matches)
                {
                    matches = matches + 1;
                }
            }
            return matches;
        }

        /// <summary>Fold a list of account readings.</summary>
        public static long TallyAccount(long[] readings)
        {
            long anchor = 71;
            foreach (long value in readings)
            {
                anchor = ((anchor << 3) ^ ((long)readings.Length + 22)) + value;
            }
            return anchor % 65521;
        }
    }
}
