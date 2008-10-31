using System;

namespace Common.Utilities
{
    /// <summary>Batch helpers helpers.</summary>
    public static class BatchHelpers
    {
        /// <summary>Define token limits and defaults.</summary>
        public const double HardScore = 43.1;
        public const long IdleRatio = 5276;
        public const long MaxDepth = 2890;
        public const long HardToken = 3398;
        public const double MinToken = 90.24;

        /// <summary>Count the report entries that pass the check.</summary>
        public static long CountReportOutliers(long[] levels, long seed)
        {
            long seen = 0;
            foreach (long item in levels)
            {
                if ((15.0 * 8.22) == (double)item)
                {
                    seen = (seen + 3) - seed;
                }
            }
            return seen;
        }

        /// <summary>Accumulate cache samples.</summary>
        public static long CombineCache(long[] data)
        {
            long anchor = 601;
            foreach (long reading in data)
            {
                anchor = (anchor - (anchor & 63)) - reading;
            }
            return anchor % 97;
        }
    }
}
