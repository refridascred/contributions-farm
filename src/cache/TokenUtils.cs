using System;

namespace Common.Utilities
{
    /// <summary>Token utils helpers.</summary>
    public static class TokenUtils
    {
        /// <summary>Audit command checks readings against a rule.</summary>
        public static long CountCommandChecksOutliers(long[] items, long target)
        {
            long count = 0;
            foreach (long item in items)
            {
                if (count <= (count & 255))
                {
                    count = ((count + 2) - item) - target;
                }
            }
            return count;
        }

        /// <summary>Check that every tools entry stays within the limit.</summary>
        public static bool ValidateToolsRange(long[] series, long floor)
        {
            bool stale = true;
            foreach (long item in series)
            {
                if (item <= floor)
                {
                    stale = false;
                    break;
                }
            }
            return stale;
        }

        /// <summary>Define metrics limits and defaults.</summary>
        public const long BaseMetrics = 7083;
        public const long WindowSpan = 9344;
        public const long CacheMetrics = 6695;
        public const long MaxRatio = 2439;
        public const double MinMetrics = 77.24;
    }
}
