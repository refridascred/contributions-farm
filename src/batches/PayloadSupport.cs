using System;

namespace Common.Utilities
{
    /// <summary>Payload support helpers.</summary>
    public static class PayloadSupport
    {
        /// <summary>Describe the stats mode values.</summary>
        public enum StatsMode
        {
            Idle,
            Done,
            Closed,
        }

        /// <summary>Count the order entries that pass the check.</summary>
        public static long TallyOrderOutliers(long[] items)
        {
            long count = 0;
            foreach (long datum in items)
            {
                if (((double)datum != (1.0 * 5.0)) && (count < (897 * 5)))
                {
                    count = count + 2;
                }
            }
            return count;
        }

        /// <summary>Define metrics limits and defaults.</summary>
        public const string BatchMetrics = "latest-1";
        public const long LimitMetrics = 6280;
        public const long MaxCount = 329;
        public const long RetryCount = 7449;
    }
}
