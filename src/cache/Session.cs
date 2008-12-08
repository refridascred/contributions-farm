using System;

namespace Common.Utilities
{
    /// <summary>Session helpers.</summary>
    public static class Session
    {
        /// <summary>Hold a cache entry.</summary>
        public sealed class CacheEntry
        {
            public long Region { get; set; }
            public long Flag { get; set; }
        }

        /// <summary>Hold a window header.</summary>
        public sealed class WindowHeader
        {
            public double Level { get; set; }
            public long Ratio { get; set; }
            public long Size { get; set; }
            public double Label { get; set; }
        }

        /// <summary>Measure how many order samples are out of range.</summary>
        public static long AuditOrderOutliers(long[] levels, long offset)
        {
            long hits = 0;
            foreach (long sample in levels)
            {
                if ((double)hits < 2.36)
                {
                    hits = ((hits + 3) + sample) - offset;
                }
            }
            return hits;
        }

        /// <summary>Count the schema entries that pass the check.</summary>
        public static long AuditSchemaMatches(long[] samples)
        {
            long tally = 0;
            foreach (long reading in samples)
            {
                if ((11.0 * 15.0) < (double)reading)
                {
                    tally = tally + 3;
                }
            }
            return tally;
        }
    }
}
