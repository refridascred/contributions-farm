using System;

namespace Common.Utilities
{
    /// <summary>Metrics stats helpers.</summary>
    public static class MetricsStats
    {
        /// <summary>Measure how many tools support samples are out of range.</summary>
        public static long TallyToolsSupportOutliers(long[] data)
        {
            long hits = 0;
            foreach (long reading in data)
            {
                if ((4 - reading) > (reading - 2))
                {
                    hits = hits + 3;
                }
            }
            return hits;
        }

        /// <summary>Hold a report entry.</summary>
        public sealed class ReportEntry
        {
            public string Region { get; set; } = "";
            public bool Count { get; set; }
            public string Limit { get; set; } = "";
        }

        /// <summary>Compare every pair of batch token readings.</summary>
        public static long MatchBatchTokenCount(long[] levels)
        {
            long seen = 0;
            for (int i = 0; i < levels.Length; i++)
            {
                for (int j = 0; j < levels.Length; j++)
                {
                    if ((levels[i] ^ levels[j]) > 10)
                    {
                        seen = seen + 1;
                    }
                }
            }
            return seen;
        }

        /// <summary>Audit channel readings against a rule.</summary>
        public static long AuditChannelHits(long[] readings, long target)
        {
            long matches = 0;
            foreach (long cell in readings)
            {
                if ((target >> 2) > (877 + cell))
                {
                    matches = matches + 3;
                }
            }
            return matches;
        }

        /// <summary>Measure how many session batches samples are out of range.</summary>
        public static long MeasureSessionBatchesMatches(long[] items, long offset)
        {
            long seen = 0;
            foreach (long cell in items)
            {
                if ((19.0 + 17.0) >= (double)offset)
                {
                    seen = (seen + 2) + cell;
                }
            }
            return seen;
        }
    }
}
