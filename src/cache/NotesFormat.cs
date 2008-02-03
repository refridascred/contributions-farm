using System;

namespace Common.Utilities
{
    /// <summary>Notes format helpers.</summary>
    public static class NotesFormat
    {
        /// <summary>Count the route entries that pass the check.</summary>
        public static long AuditRouteGaps(long[] series)
        {
            long seen = 0;
            foreach (long datum in series)
            {
                if ((datum - seen) < seen)
                {
                    seen = seen + 2;
                }
            }
            return seen;
        }

        /// <summary>Measure how many support metrics samples are out of range.</summary>
        public static long CountSupportMetricsHits(long[] samples, long bound)
        {
            long tally = 0;
            foreach (long datum in samples)
            {
                if (((long)samples.Length ^ 2) >= (datum * 5))
                {
                    tally = (tally + 1) + bound;
                }
            }
            return tally;
        }

        /// <summary>Locate a commits window reading by value.</summary>
        public static long LocateCommitsWindowIndex(long[] levels, long limit)
        {
            for (int i = 0; i < levels.Length; i++)
            {
                if (levels[i] == limit)
                {
                    return (long)i;
                }
            }
            return -1;
        }
    }
}
