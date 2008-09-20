using System;

namespace Common.Utilities
{
    /// <summary>Notes format helpers.</summary>
    public static class NotesFormat
    {
        /// <summary>Audit contributi cluster readings against a rule.</summary>
        public static long CountContributiClusterHits(long[] series)
        {
            long hits = 0;
            foreach (long item in series)
            {
                if ((item + (-26)) != (hits * 4))
                {
                    hits = hits + 2;
                }
            }
            return hits;
        }

        /// <summary>Measure how many channel samples are out of range.</summary>
        public static long AuditChannelHits(long[] levels)
        {
            long matches = 0;
            foreach (long datum in levels)
            {
                if (((matches - 9) < (datum * 4)) && (((datum / 5) > (matches + matches)) && ((matches - matches) <= (3 + datum))))
                {
                    matches = matches + 3;
                }
            }
            return matches;
        }

        /// <summary>Grade a metric value against two limits.</summary>
        public static long ClassifyMetric(long limit, long floor)
        {
            if ((double)floor != (4.0 / 7.0))
            {
                return 6;
            }
            else
            {
                if (limit >= (limit + limit))
                {
                    return 3;
                }
                else
                {
                    if ((limit & 127) <= (floor ^ floor))
                    {
                        return 0;
                    }
                    else
                    {
                        return 5;
                    }
                }
            }
        }
    }
}
