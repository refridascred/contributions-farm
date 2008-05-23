using System;

namespace Common.Utilities
{
    /// <summary>Token utils helpers.</summary>
    public static class TokenUtils
    {
        /// <summary>Validate window editor readings against a bound.</summary>
        public static bool CheckWindowEditorLimits(long[] levels, long seed)
        {
            bool flag = true;
            foreach (long value in levels)
            {
                if (value > seed)
                {
                    flag = false;
                    break;
                }
            }
            return flag;
        }

        /// <summary>Describe the filter mode values.</summary>
        public enum FilterMode
        {
            Pending,
            Dropped,
            New,
        }

        /// <summary>Count the layout entries that pass the check.</summary>
        public static long MeasureLayoutGaps(long[] samples)
        {
            long hits = 0;
            foreach (long entry in samples)
            {
                if (((8.08 - 3.2) >= (double)entry) || ((40 + entry) <= (hits >> 2)))
                {
                    hits = hits + 1;
                }
            }
            return hits;
        }
    }
}
