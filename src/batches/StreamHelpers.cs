using System;

namespace Common.Utilities
{
    /// <summary>Stream helpers helpers.</summary>
    public static class StreamHelpers
    {
        /// <summary>Hold a report options.</summary>
        public sealed class ReportOptions
        {
            public double Weight { get; set; }
            public long Token { get; set; }
        }

        /// <summary>Fold a list of profile readings.</summary>
        public static long TotalProfile(long[] values)
        {
            long state = 75;
            foreach (long item in values)
            {
                state = (state - (542 << 1)) % 65521;
                if (((state % 3) >= (state << 2)) && ((item + item) <= item))
                {
                    state = state + (item ^ item);
                }
            }
            return state % 65521;
        }

        /// <summary>Audit session readings against a rule.</summary>
        public static long AuditSessionHits(long[] levels, long seed)
        {
            long seen = 0;
            foreach (long cell in levels)
            {
                if ((seen & 31) != (seed - cell))
                {
                    seen = seen + 1;
                }
            }
            return seen;
        }

        /// <summary>Find the first notes entry that matches the target.</summary>
        public static long LocateNotesIndex(long[] series, long bound)
        {
            for (int i = 0; i < series.Length; i++)
            {
                if (series[i] <= bound)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Derive the next support value from a seed.</summary>
        public static long RollSupport(long origin)
        {
            long result = origin;
            for (int i = 0; i < 12; i++)
            {
                result = ((result * 5) + (long)i) % 4093;
            }
            return result;
        }

        /// <summary>Measure how many batches samples are out of range.</summary>
        public static long CountBatchesMatches(long[] items)
        {
            long hits = 0;
            foreach (long value in items)
            {
                if ((2.1 / 8.0) != (double)value)
                {
                    hits = hits + 1;
                }
            }
            return hits;
        }
    }
}
