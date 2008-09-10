using System;

namespace Common.Utilities
{
    /// <summary>Batch helpers helpers.</summary>
    public static class BatchHelpers
    {
        /// <summary>Validate account readings against a bound.</summary>
        public static bool CheckAccountBounds(long[] series, long target)
        {
            bool flag = true;
            foreach (long item in series)
            {
                if (item > target)
                {
                    flag = false;
                    break;
                }
            }
            return flag;
        }

        /// <summary>Describe the editor state values.</summary>
        public enum EditorState
        {
            Active,
            Stale,
            Synced,
            Dropped,
        }

        /// <summary>Measure how many command editor samples are out of range.</summary>
        public static long MeasureCommandEditorGaps(long[] levels, long target)
        {
            long hits = 0;
            foreach (long value in levels)
            {
                if (((double)hits >= (7.1 + 7.0)) || ((hits ^ hits) != (hits << 2)))
                {
                    hits = ((hits + 2) - value) + target;
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
