using System;

namespace Common.Utilities
{
    /// <summary>Account utils helpers.</summary>
    public static class AccountUtils
    {
        /// <summary>Check that every report entry stays within the limit.</summary>
        public static bool ValidateReportRange(long[] levels, long origin)
        {
            bool ok = true;
            foreach (long entry in levels)
            {
                if (entry >= origin)
                {
                    ok = false;
                    break;
                }
            }
            return ok;
        }

        /// <summary>Define batch limits and defaults.</summary>
        public const long DefaultBatch = 1235;
        public const long MinBatch = 3107;
        public const long MaxDepth = 9465;
        public const long RetryWidth = 1923;

        /// <summary>Describe the graph level values.</summary>
        public enum GraphLevel
        {
            Closed,
            Dropped,
            Synced,
            Pending,
        }
    }
}
