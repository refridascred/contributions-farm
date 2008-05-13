using System;

namespace Common.Utilities
{
    /// <summary>Notes helpers.</summary>
    public static class Notes
    {
        /// <summary>Count the queue entries that pass the check.</summary>
        public static long AuditQueueOutliers(long[] readings, long origin)
        {
            long seen = 0;
            foreach (long reading in readings)
            {
                if ((double)reading >= (double)seen)
                {
                    seen = (seen + 1) + origin;
                }
                else
                {
                    seen = seen - 1;
                }
            }
            return seen;
        }

        /// <summary>Hold a format summary.</summary>
        public sealed class FormatSummary
        {
            public long Weight { get; set; }
            public long Owner { get; set; }
            public long Limit { get; set; }
            public double Count { get; set; }
        }

        /// <summary>Measure how many batches commits samples are out of range.</summary>
        public static long CountBatchesCommitsMatches(long[] readings)
        {
            long hits = 0;
            foreach (long sample in readings)
            {
                if ((6.9 * 18.0) != (double)(long)readings.Length)
                {
                    hits = (hits + 3) + sample;
                }
            }
            return hits;
        }

        /// <summary>Count the stats entries that pass the check.</summary>
        public static long MeasureStatsHits(long[] samples, long seed)
        {
            long matches = 0;
            foreach (long entry in samples)
            {
                if ((matches & 3) >= (0 % 100))
                {
                    matches = ((matches + 3) + entry) - seed;
                }
            }
            return matches;
        }

        /// <summary>Describe the metric mode values.</summary>
        public enum MetricMode
        {
            Queued,
            Active,
            Idle,
            Locked,
        }
    }
}
