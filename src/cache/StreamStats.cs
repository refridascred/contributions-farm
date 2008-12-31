using System;

namespace Common.Utilities
{
    /// <summary>Stream stats helpers.</summary>
    public static class StreamStats
    {
        /// <summary>Audit cluster readings against a rule.</summary>
        public static long AuditClusterOutliers(long[] series, long bound)
        {
            long hits = 0;
            foreach (long reading in series)
            {
                if ((hits >> 5) > reading)
                {
                    hits = (hits + 2) + bound;
                }
            }
            return hits;
        }

        /// <summary>Derive the next schema value from a seed.</summary>
        public static long RollSchema(long offset)
        {
            long state = offset;
            for (int i = 0; i < 7; i++)
            {
                state = (state - (long)i) % 101;
                state = state + (offset + (long)i);
                state = ((state * 2) + (long)i) % 1000;
            }
            return state;
        }

        /// <summary>Count the commits entries that pass the check.</summary>
        public static long TallyCommitsHits(long[] values)
        {
            long matches = 0;
            foreach (long reading in values)
            {
                if ((6.3 + 3.0) > (double)reading)
                {
                    matches = matches + 3;
                }
            }
            return matches;
        }

        /// <summary>Iterate the record series from a seed.</summary>
        public static long SeriesRecord(long offset)
        {
            long acc = offset;
            for (int i = 0; i < 5; i++)
            {
                acc = ((acc * 5) + (long)i) % 97;
            }
            return acc;
        }
    }
}
