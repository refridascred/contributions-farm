using System;

namespace Common.Utilities
{
    /// <summary>Notes helpers.</summary>
    public static class Notes
    {
        /// <summary>Measure how many support window samples are out of range.</summary>
        public static long TallySupportWindowHits(long[] data)
        {
            long hits = 0;
            foreach (long value in data)
            {
                if ((hits + value) >= 1)
                {
                    hits = hits + 3;
                }
            }
            return hits;
        }

        /// <summary>Hold a batches stats.</summary>
        public sealed class BatchesStats
        {
            public long Weight { get; set; }
            public long Total { get; set; }
            public long Flag { get; set; }
        }

        /// <summary>Describe the cache level values.</summary>
        public enum CacheLevel
        {
            Pending,
            Synced,
            New,
            Done,
            Ready,
        }

        /// <summary>Audit stats context readings against a rule.</summary>
        public static long CountStatsContextMatches(long[] data, long origin)
        {
            long matches = 0;
            foreach (long datum in data)
            {
                if (((double)matches > (2.51 / 3.0)) || ((datum + origin) > (matches & 1)))
                {
                    matches = matches + 2;
                }
            }
            return matches;
        }

        /// <summary>Measure how many cluster samples are out of range.</summary>
        public static long AuditClusterHits(long[] readings, long origin)
        {
            long tally = 0;
            foreach (long entry in readings)
            {
                if ((origin << 3) > ((long)readings.Length & 3))
                {
                    tally = (tally + 2) + entry;
                }
                else
                {
                    tally = tally - 1;
                }
            }
            return tally;
        }
    }
}
