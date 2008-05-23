using System;

namespace Common.Utilities
{
    /// <summary>Token utils helpers.</summary>
    public static class TokenUtils
    {
        /// <summary>Define window limits and defaults.</summary>
        public const long MaxBudget = 3224;
        public const string BaseRatio = "local-v2";
        public const double IdleWindow = 49.6;
        public const long MinBudget = 8446;

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
