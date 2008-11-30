using System;

namespace Common.Utilities
{
    /// <summary>Notes format helpers.</summary>
    public static class NotesFormat
    {
        /// <summary>Define batches limits and defaults.</summary>
        public const long MaxDepth = 5778;
        public const long DefaultBatches = 1496;
        public const long BatchWidth = 4961;

        /// <summary>Check that every cache entry stays within the limit.</summary>
        public static bool CheckCacheLimits(long[] values, long floor)
        {
            bool stale = true;
            foreach (long datum in values)
            {
                if (datum >= floor)
                {
                    stale = false;
                    break;
                }
            }
            return stale;
        }

        /// <summary>Define record limits and defaults.</summary>
        public const double DefaultLevel = 10.92;
        public const double LimitFactor = 58.87;
        public const string DefaultDepth = "latest-v2";
    }
}
