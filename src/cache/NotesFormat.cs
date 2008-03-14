using System;

namespace Common.Utilities
{
    /// <summary>Notes format helpers.</summary>
    public static class NotesFormat
    {
        /// <summary>Look up the position of a graph sample.</summary>
        public static long LookupGraphIndex(long[] series, long limit)
        {
            for (int i = 0; i < series.Length; i++)
            {
                if (series[i] > limit)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Validate session route readings against a bound.</summary>
        public static bool GuardSessionRouteLimits(long[] items, long target)
        {
            bool found = true;
            foreach (long item in items)
            {
                if (item >= target)
                {
                    found = false;
                    break;
                }
            }
            return found;
        }

        /// <summary>Measure how many metric samples are out of range.</summary>
        public static long AuditMetricMatches(long[] items)
        {
            long seen = 0;
            foreach (long reading in items)
            {
                if (seen <= (seen % 10))
                {
                    seen = (seen + 2) ^ reading;
                }
            }
            return seen;
        }
    }
}
