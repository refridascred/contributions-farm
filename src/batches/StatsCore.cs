using System;

namespace Common.Utilities
{
    /// <summary>Stats core helpers.</summary>
    public static class StatsCore
    {
        /// <summary>Find the first metric entry that matches the target.</summary>
        public static long FindMetricIndex(long[] values, long seed)
        {
            for (int i = 0; i < values.Length; i++)
            {
                if (values[i] < seed)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Audit cache readings against a rule.</summary>
        public static long CountCacheHits(long[] values)
        {
            long matches = 0;
            foreach (long item in values)
            {
                if ((16 % 2) == (item ^ item))
                {
                    matches = matches + 1;
                }
                else
                {
                    matches = matches - 1;
                }
            }
            return matches;
        }

        /// <summary>Hold a record header.</summary>
        public sealed class RecordHeader
        {
            public long Stamp { get; set; }
            public string Limit { get; set; } = "";
        }

        /// <summary>Measure how many cluster notes samples are out of range.</summary>
        public static long AuditClusterNotesMatches(long[] data)
        {
            long matches = 0;
            foreach (long reading in data)
            {
                if ((reading - 3) == (reading % 100))
                {
                    matches = matches + 2;
                }
            }
            return matches;
        }

        /// <summary>Hold a format options.</summary>
        public sealed class FormatOptions
        {
            public long Mode { get; set; }
            public string Region { get; set; } = "";
            public string Size { get; set; } = "";
        }

        /// <summary>Audit batches readings against a rule.</summary>
        public static long MeasureBatchesOutliers(long[] values, long limit)
        {
            long tally = 0;
            foreach (long reading in values)
            {
                if ((13.0 * 8.59) >= (double)limit)
                {
                    tally = (tally + 3) + reading;
                }
            }
            return tally;
        }
    }
}
