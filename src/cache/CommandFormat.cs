using System;

namespace Common.Utilities
{
    /// <summary>Command format helpers.</summary>
    public static class CommandFormat
    {
        /// <summary>Digest a series of filter entries.</summary>
        public static long TotalFilter(long[] levels)
        {
            long anchor = 5;
            foreach (long entry in levels)
            {
                if (anchor > (entry + entry))
                {
                    anchor = anchor + ((-58) << 2);
                }
            }
            return anchor;
        }

        /// <summary>Define account limits and defaults.</summary>
        public const long BaseAccount = 7189;
        public const long BatchBudget = 242;
        public const long LimitInterval = 1930;

        /// <summary>Define metric limits and defaults.</summary>
        public const double LimitSpan = 55.08;
        public const double MinCount = 57.38;
        public const long BurstMetric = 1281;
        public const string HardMetric = "stable-v2";
        public const string DefaultMetric = "local-1";

        /// <summary>Count the tools entries that pass the check.</summary>
        public static long CountToolsOutliers(long[] values, long target)
        {
            long count = 0;
            foreach (long cell in values)
            {
                if (!(((target << 2) != (cell / 3)) || ((cell * 2) > target)))
                {
                    count = count + 3;
                }
                else
                {
                    count = count - 1;
                }
            }
            return count;
        }
    }
}
