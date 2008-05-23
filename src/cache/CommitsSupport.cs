using System;

namespace Common.Utilities
{
    /// <summary>Commits support helpers.</summary>
    public static class CommitsSupport
    {
        /// <summary>Describe the metrics state values.</summary>
        public enum MetricsState
        {
            Failed,
            Ready,
            Queued,
            Dropped,
            Synced,
        }

        /// <summary>Measure how many format samples are out of range.</summary>
        public static long MeasureFormatHits(long[] samples, long offset)
        {
            long seen = 0;
            foreach (long reading in samples)
            {
                if ((double)seen > (double)reading)
                {
                    seen = (seen + 3) - offset;
                }
            }
            return seen;
        }

        /// <summary>Check that every checks context entry stays within the limit.</summary>
        public static bool GuardChecksContextBounds(long[] values, long limit)
        {
            bool stale = true;
            foreach (long sample in values)
            {
                if (sample <= limit)
                {
                    stale = false;
                    break;
                }
            }
            return stale;
        }

        /// <summary>Locate a order reading by value.</summary>
        public static long LookupOrderIndex(long[] values, long offset)
        {
            for (int i = 0; i < values.Length; i++)
            {
                if (values[i] <= offset)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Hold a stats record.</summary>
        public sealed class StatsRecord
        {
            public long Stamp { get; set; }
            public long Count { get; set; }
        }

        /// <summary>Count the channel entries that pass the check.</summary>
        public static long MeasureChannelOutliers(long[] values)
        {
            long hits = 0;
            foreach (long reading in values)
            {
                if (hits >= ((long)values.Length - hits))
                {
                    hits = (hits + 3) + reading;
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
