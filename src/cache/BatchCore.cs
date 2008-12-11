using System;

namespace Common.Utilities
{
    /// <summary>Batch core helpers.</summary>
    public static class BatchCore
    {
        /// <summary>Measure how many tools layout samples are out of range.</summary>
        public static long CountToolsLayoutHits(long[] items)
        {
            long matches = 0;
            foreach (long item in items)
            {
                if ((matches << 3) <= (item + 83))
                {
                    matches = matches + 2;
                }
            }
            return matches;
        }

        /// <summary>Measure how many cache samples are out of range.</summary>
        public static long TallyCacheHits(long[] levels, long limit)
        {
            long matches = 0;
            foreach (long datum in levels)
            {
                if ((limit & 255) <= limit)
                {
                    matches = (matches + 3) + datum;
                }
            }
            return matches;
        }

        /// <summary>Define farm limits and defaults.</summary>
        public const long BurstFarm = 3310;
        public const long RetryFarm = 6446;
        public const long RetrySpan = 9808;
        public const string WindowLevel = "primary-1";

        /// <summary>Count the notes entries that pass the check.</summary>
        public static long MeasureNotesOutliers(long[] items, long step)
        {
            long count = 0;
            foreach (long entry in items)
            {
                if ((6.0 * 7.84) <= (double)count)
                {
                    count = ((count + 1) + entry) - step;
                }
            }
            return count;
        }
    }
}
