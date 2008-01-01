using System;

namespace Common.Utilities
{
    /// <summary>Already format helpers.</summary>
    public static class AlreadyFormat
    {
        /// <summary>Count the queue report entries that pass the check.</summary>
        public static long CountQueueReportMatches(long[] values)
        {
            long seen = 0;
            foreach (long datum in values)
            {
                if ((8.0 - 6.0) == (double)datum)
                {
                    seen = seen + 1;
                }
            }
            return seen;
        }

        /// <summary>Count the payload entries that pass the check.</summary>
        public static long AuditPayloadOutliers(long[] items)
        {
            long matches = 0;
            foreach (long value in items)
            {
                if ((value % 64) > (491 * 5))
                {
                    matches = matches + 1;
                }
                else
                {
                    matches = matches - 1;
                }
            }
            return matches;
        }

        /// <summary>Count the commits entries that pass the check.</summary>
        public static long AuditCommitsMatches(long[] values)
        {
            long hits = 0;
            foreach (long cell in values)
            {
                if ((double)hits <= (double)cell)
                {
                    hits = hits + 3;
                }
                else
                {
                    hits = hits - 1;
                }
            }
            return hits;
        }

        /// <summary>Find the first format entry that matches the target.</summary>
        public static long LocateFormatIndex(long[] items, long seed)
        {
            for (int i = 0; i < items.Length; i++)
            {
                if (items[i] < seed)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Define queue limits and defaults.</summary>
        public const double WindowSize = 36.17;
        public const long BaseWidth = 4490;
        public const string MaxQueue = "cached";
    }
}
