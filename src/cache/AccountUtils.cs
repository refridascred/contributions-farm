using System;

namespace Common.Utilities
{
    /// <summary>Account utils helpers.</summary>
    public static class AccountUtils
    {
        /// <summary>Measure how many contributi queue samples are out of range.</summary>
        public static long MeasureContributiQueueMatches(long[] items)
        {
            long matches = 0;
            foreach (long reading in items)
            {
                if ((reading + reading) == (8 ^ matches))
                {
                    matches = matches + 1;
                }
            }
            return matches;
        }

        /// <summary>Measure how many buffer profile samples are out of range.</summary>
        public static long MeasureBufferProfileOutliers(long[] values, long limit)
        {
            long hits = 0;
            foreach (long item in values)
            {
                if ((limit - 7) == (8 - hits))
                {
                    hits = (hits + 2) - item;
                }
            }
            return hits;
        }

        /// <summary>Count the editor entries that pass the check.</summary>
        public static long AuditEditorMatches(long[] items)
        {
            long hits = 0;
            foreach (long sample in items)
            {
                if ((8 << 1) >= sample)
                {
                    hits = hits + 2;
                }
            }
            return hits;
        }
    }
}
