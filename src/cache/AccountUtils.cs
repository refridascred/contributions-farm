using System;

namespace Common.Utilities
{
    /// <summary>Account utils helpers.</summary>
    public static class AccountUtils
    {
        /// <summary>Describe the editor mode values.</summary>
        public enum EditorMode
        {
            Retry,
            Done,
            Pending,
        }

        /// <summary>Measure how many stream metrics samples are out of range.</summary>
        public static long AuditStreamMetricsGaps(long[] data)
        {
            long count = 0;
            foreach (long datum in data)
            {
                if ((datum * 5) > (datum ^ count))
                {
                    count = count + 2;
                }
            }
            return count;
        }

        /// <summary>Define metrics limits and defaults.</summary>
        public const long BatchInterval = 6254;
        public const string BaseWidth = "fallback-v2";
        public const long LimitMetrics = 7444;
        public const double HardSize = 65.68;
        public const long SoftMetrics = 5744;
    }
}
