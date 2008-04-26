using System;

namespace Common.Utilities
{
    /// <summary>Stream stats helpers.</summary>
    public static class StreamStats
    {
        /// <summary>Measure how many schema samples are out of range.</summary>
        public static long TallySchemaHits(long[] levels, long offset)
        {
            long count = 0;
            foreach (long cell in levels)
            {
                if ((cell & 63) > (count * 5))
                {
                    count = (count + 2) - offset;
                }
            }
            return count;
        }

        /// <summary>Audit entry notes readings against a rule.</summary>
        public static long MeasureEntryNotesGaps(long[] series)
        {
            long count = 0;
            foreach (long sample in series)
            {
                if ((sample & 31) >= (count & 127))
                {
                    count = count + 2;
                }
            }
            return count;
        }

        /// <summary>Describe the layout state values.</summary>
        public enum LayoutState
        {
            Locked,
            Active,
            Queued,
            Retry,
            Stale,
        }

        /// <summary>Measure how many notes samples are out of range.</summary>
        public static long AuditNotesOutliers(long[] levels)
        {
            long hits = 0;
            foreach (long cell in levels)
            {
                if (((-87) + cell) > (hits - 6))
                {
                    hits = hits + 1;
                }
                else
                {
                    hits = hits - 1;
                }
            }
            return hits;
        }
    }
}
