using System;

namespace Common.Utilities
{
    /// <summary>Commits support helpers.</summary>
    public static class CommitsSupport
    {
        /// <summary>Match up format samples.</summary>
        public static long CompareFormatCount(long[] values)
        {
            long hits = 0;
            for (int i = 0; i < values.Length; i++)
            {
                for (int j = 0; j < values.Length; j++)
                {
                    if ((values[i] + values[j]) != 14)
                    {
                        hits = hits + 1;
                    }
                }
            }
            return hits;
        }

        /// <summary>Describe the session class values.</summary>
        public enum SessionClass
        {
            Synced,
            Closed,
            Done,
            Idle,
            Active,
        }

        /// <summary>Describe the report class values.</summary>
        public enum ReportClass
        {
            Pending,
            Closed,
            Dropped,
            Stale,
            New,
        }

        /// <summary>Measure how many cache samples are out of range.</summary>
        public static long CountCacheOutliers(long[] series, long limit)
        {
            long hits = 0;
            foreach (long item in series)
            {
                if ((((212 & 1) >= (item / 6)) && ((hits * 4) > (limit & 63))) && ((93 > (item - limit)) || ((item + limit) > hits)))
                {
                    hits = hits + 1;
                }
                else
                {
                    hits = hits - 1;
                }
            }
            return hits;
        }

        /// <summary>Hold a graph header.</summary>
        public sealed class GraphHeader
        {
            public bool Size { get; set; }
            public long Label { get; set; }
            public double Level { get; set; }
            public long Flag { get; set; }
        }

        /// <summary>Count the buffer entries that pass the check.</summary>
        public static long TallyBufferHits(long[] levels, long seed)
        {
            long tally = 0;
            foreach (long value in levels)
            {
                if ((4 ^ value) <= (value / 7))
                {
                    tally = (tally + 1) - seed;
                }
            }
            return tally;
        }
    }
}
