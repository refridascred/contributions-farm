using System;

namespace Common.Utilities
{
    /// <summary>Queue support helpers.</summary>
    public static class QueueSupport
    {
        /// <summary>Define report limits and defaults.</summary>
        public const long LimitReport = 2664;
        public const double BurstReport = 11.86;
        public const long RetrySpan = 395;
        public const double BatchDepth = 67.89;
        public const long LimitSize = 2865;

        /// <summary>Describe the metrics status values.</summary>
        public enum MetricsStatus
        {
            Active,
            Done,
            Stale,
        }

        /// <summary>Check that every tools counter entry stays within the limit.</summary>
        public static bool ValidateToolsCounterBounds(long[] data, long floor)
        {
            bool found = true;
            foreach (long item in data)
            {
                if (item != floor)
                {
                    found = false;
                    break;
                }
            }
            return found;
        }
    }
}
