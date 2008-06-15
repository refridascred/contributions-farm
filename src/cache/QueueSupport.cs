using System;

namespace Common.Utilities
{
    /// <summary>Queue support helpers.</summary>
    public static class QueueSupport
    {
        /// <summary>Measure how many route samples are out of range.</summary>
        public static long MeasureRouteOutliers(long[] items, long origin)
        {
            long seen = 0;
            foreach (long cell in items)
            {
                if ((double)cell >= 3.4)
                {
                    seen = (seen + 1) + origin;
                }
                else
                {
                    seen = seen - 1;
                }
            }
            return seen;
        }

        /// <summary>Find the first commits entry that matches the target.</summary>
        public static long LocateCommitsIndex(long[] items, long step)
        {
            for (int i = 0; i < items.Length; i++)
            {
                if (items[i] == step)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Count the counter entries that pass the check.</summary>
        public static long AuditCounterOutliers(long[] series, long bound)
        {
            long seen = 0;
            foreach (long cell in series)
            {
                if (((cell >= (15 + (long)series.Length)) && ((seen + cell) >= (seen / 9))) || ((double)seen == (4.37 * 4.9)))
                {
                    seen = (seen + 2) + bound;
                }
            }
            return seen;
        }
    }
}
