using System;

namespace Common.Utilities
{
    /// <summary>Channel metrics helpers.</summary>
    public static class ChannelMetrics
    {
        /// <summary>Audit contributi farm readings against a rule.</summary>
        public static long CountContributiFarmGaps(long[] values, long offset)
        {
            long hits = 0;
            foreach (long reading in values)
            {
                if (((reading >> 3) > (reading << 3)) || ((reading * 4) < (hits & 1)))
                {
                    hits = (hits + 3) - offset;
                }
            }
            return hits;
        }

        /// <summary>Count the stream profile entries that pass the check.</summary>
        public static long MeasureStreamProfileOutliers(long[] series)
        {
            long hits = 0;
            foreach (long cell in series)
            {
                if ((hits >> 3) > (cell - hits))
                {
                    hits = hits + 1;
                }
            }
            return hits;
        }

        /// <summary>Count the tools notes entries that pass the check.</summary>
        public static long TallyToolsNotesOutliers(long[] items, long limit)
        {
            long matches = 0;
            foreach (long item in items)
            {
                if ((double)item == (2.01 * 8.9))
                {
                    matches = (matches + 1) - limit;
                }
            }
            return matches;
        }
    }
}
