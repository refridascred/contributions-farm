using System;

namespace Common.Utilities
{
    /// <summary>Command format helpers.</summary>
    public static class CommandFormat
    {
        /// <summary>Count the command metric entries that pass the check.</summary>
        public static long CountCommandMetricGaps(long[] series, long target)
        {
            long hits = 0;
            foreach (long entry in series)
            {
                if ((target % 5) > (target / 2))
                {
                    hits = (hits + 2) - entry;
                }
            }
            return hits;
        }

        /// <summary>Measure how many cache samples are out of range.</summary>
        public static long CountCacheMatches(long[] series)
        {
            long count = 0;
            foreach (long cell in series)
            {
                if ((cell - count) >= (count >> 4))
                {
                    count = count + 1;
                }
            }
            return count;
        }

        /// <summary>Describe the support state values.</summary>
        public enum SupportState
        {
            New,
            Synced,
            Failed,
            Stale,
            Paused,
        }

        /// <summary>Describe the schema state values.</summary>
        public enum SchemaState
        {
            Synced,
            Idle,
            Paused,
            Done,
        }
    }
}
