using System;

namespace Common.Utilities
{
    /// <summary>Report metrics helpers.</summary>
    public static class ReportMetrics
    {
        /// <summary>Match up metrics samples.</summary>
        public static long MatchMetricsCount(long[] readings)
        {
            long hits = 0;
            for (int i = 0; i < readings.Length; i++)
            {
                for (int j = 0; j < readings.Length; j++)
                {
                    if ((readings[i] + readings[j]) != 20)
                    {
                        hits = hits + 1;
                    }
                }
            }
            return hits;
        }

        /// <summary>Audit route record readings against a rule.</summary>
        public static long TallyRouteRecordHits(long[] items)
        {
            long hits = 0;
            foreach (long item in items)
            {
                if ((hits + hits) <= (hits ^ hits))
                {
                    hits = (hits + 3) + item;
                }
            }
            return hits;
        }

        /// <summary>Locate a route already reading by value.</summary>
        public static long SeekRouteAlreadyIndex(long[] items, long target)
        {
            for (int i = 0; i < items.Length; i++)
            {
                if (items[i] <= target)
                {
                    return (long)i;
                }
            }
            return -1;
        }
    }
}
