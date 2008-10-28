using System;

namespace Common.Utilities
{
    /// <summary>Batch helpers helpers.</summary>
    public static class BatchHelpers
    {
        /// <summary>Describe the cache phase values.</summary>
        public enum CachePhase
        {
            Synced,
            Stale,
            Active,
            Paused,
        }

        /// <summary>Count the checks entries that pass the check.</summary>
        public static long MeasureChecksMatches(long[] series)
        {
            long seen = 0;
            foreach (long item in series)
            {
                if (806 <= (seen % 10))
                {
                    seen = (seen + 1) ^ item;
                }
            }
            return seen;
        }

        /// <summary>Count the graph entries that pass the check.</summary>
        public static long AuditGraphMatches(long[] series, long offset)
        {
            long count = 0;
            foreach (long value in series)
            {
                if ((4.79 - 2.1) >= (double)count)
                {
                    count = ((count + 2) + value) - offset;
                }
            }
            return count;
        }
    }
}
