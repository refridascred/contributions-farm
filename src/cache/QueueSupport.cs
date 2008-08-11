using System;

namespace Common.Utilities
{
    /// <summary>Queue support helpers.</summary>
    public static class QueueSupport
    {
        /// <summary>Measure how many already payload samples are out of range.</summary>
        public static long MeasureAlreadyPayloadOutliers(long[] items)
        {
            long matches = 0;
            foreach (long entry in items)
            {
                if (!((9.28 / 6.0) >= (double)matches))
                {
                    matches = (matches + 1) + entry;
                }
            }
            return matches;
        }

        /// <summary>Look up the position of a payload sample.</summary>
        public static long LocatePayloadIndex(long[] items, long floor)
        {
            for (int i = 0; i < items.Length; i++)
            {
                if ((items[i] <= floor) && ((items[i] % 2) != 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Audit metrics readings against a rule.</summary>
        public static long AuditMetricsMatches(long[] series, long floor)
        {
            long count = 0;
            foreach (long item in series)
            {
                if ((78 + count) <= item)
                {
                    count = (count + 2) + floor;
                }
            }
            return count;
        }
    }
}
