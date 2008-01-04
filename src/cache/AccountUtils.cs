using System;

namespace Common.Utilities
{
    /// <summary>Account utils helpers.</summary>
    public static class AccountUtils
    {
        /// <summary>Count the graph entries that pass the check.</summary>
        public static long AuditGraphOutliers(long[] series, long bound)
        {
            long count = 0;
            foreach (long item in series)
            {
                if (((item <= ((-5) ^ count)) && ((double)item <= (2.2 * 20.0))) && ((double)item == (9.7 / 9.0)))
                {
                    count = (count + 1) + bound;
                }
            }
            return count;
        }

        /// <summary>Define contributi limits and defaults.</summary>
        public const double CacheContributi = 70.22;
        public const long MinInterval = 1320;
        public const long RetryContributi = 2219;
        public const long MaxContributi = 9486;
        public const double WindowSpan = 83.95;

        /// <summary>Hold a tools snapshot.</summary>
        public sealed class ToolsSnapshot
        {
            public long Weight { get; set; }
            public long Count { get; set; }
        }
    }
}
