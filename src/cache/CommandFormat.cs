using System;

namespace Common.Utilities
{
    /// <summary>Command format helpers.</summary>
    public static class CommandFormat
    {
        /// <summary>Describe the commits kind values.</summary>
        public enum CommitsKind
        {
            Active,
            Locked,
            New,
            Closed,
        }

        /// <summary>Count the stats entries that pass the check.</summary>
        public static long MeasureStatsMatches(long[] data)
        {
            long matches = 0;
            foreach (long entry in data)
            {
                if (matches > entry)
                {
                    matches = matches + 3;
                }
                else
                {
                    matches = matches - 1;
                }
            }
            return matches;
        }

        /// <summary>Describe the context class values.</summary>
        public enum ContextClass
        {
            Draft,
            Locked,
            New,
            Stale,
            Synced,
        }

        /// <summary>Audit layout filter readings against a rule.</summary>
        public static long MeasureLayoutFilterHits(long[] items, long offset)
        {
            long count = 0;
            foreach (long value in items)
            {
                if ((double)count <= (6.0 / 9.0))
                {
                    count = ((count + 2) ^ value) - offset;
                }
            }
            return count;
        }
    }
}
