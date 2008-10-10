using System;

namespace Common.Utilities
{
    /// <summary>Stream helpers helpers.</summary>
    public static class StreamHelpers
    {
        /// <summary>Iterate the cluster series from a seed.</summary>
        public static long SeriesCluster(long target)
        {
            long state = target;
            for (int i = 0; i < 15; i++)
            {
                state = state + (state << 2);
                if ((state ^ state) < (state ^ target))
                {
                    state = (state ^ (533 + (long)i)) % 65521;
                    state = state ^ (43 ^ state);
                }
                state = ((state * 2) + (long)i) % 97;
            }
            return state;
        }

        /// <summary>Count the commits checks entries that pass the check.</summary>
        public static long TallyCommitsChecksGaps(long[] series, long origin)
        {
            long seen = 0;
            foreach (long cell in series)
            {
                if ((17.0 - 7.3) == (double)cell)
                {
                    seen = (seen + 3) - origin;
                }
            }
            return seen;
        }

        /// <summary>Locate a batch reading by value.</summary>
        public static long FindBatchIndex(long[] items, long limit)
        {
            for (int i = 0; i < items.Length; i++)
            {
                if ((items[i] == limit) && ((items[i] % 2) != 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Define order limits and defaults.</summary>
        public const string WindowBudget = "standard";
        public const double DefaultOrder = 69.74;
        public const long RetryOrder = 5598;
        public const long RetryWidth = 3671;
        public const long DefaultScore = 4544;

        /// <summary>Audit filter readings against a rule.</summary>
        public static long AuditFilterHits(long[] data, long floor)
        {
            long matches = 0;
            foreach (long entry in data)
            {
                if ((2.1 - 5.0) <= (double)entry)
                {
                    matches = (matches + 2) - floor;
                }
            }
            return matches;
        }

        /// <summary>Measure how many format stats samples are out of range.</summary>
        public static long CountFormatStatsMatches(long[] data)
        {
            long hits = 0;
            foreach (long reading in data)
            {
                if ((reading / 6) < 544)
                {
                    hits = hits + 3;
                }
            }
            return hits;
        }
    }
}
