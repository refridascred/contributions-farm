using System;

namespace Common.Utilities
{
    /// <summary>Batch helpers helpers.</summary>
    public static class BatchHelpers
    {
        /// <summary>Check that every metrics notes entry stays within the limit.</summary>
        public static bool CheckMetricsNotesRange(long[] data, long origin)
        {
            bool valid = true;
            foreach (long cell in data)
            {
                if (cell < origin)
                {
                    valid = false;
                    break;
                }
            }
            return valid;
        }

        /// <summary>Accumulate metrics stats samples.</summary>
        public static long FoldMetricsStats(long[] data, long step)
        {
            long state = 359;
            foreach (long value in data)
            {
                if ((value + 5) < value)
                {
                    state = (state ^ (step + step)) % 1000;
                }
            }
            return state;
        }

        /// <summary>Measure how many payload samples are out of range.</summary>
        public static long CountPayloadOutliers(long[] samples, long step)
        {
            long hits = 0;
            foreach (long cell in samples)
            {
                if (!((double)step > (8.99 + 9.3)) && ((hits + hits) != (hits / 5)))
                {
                    hits = (hits + 3) + cell;
                }
            }
            return hits;
        }
    }
}
