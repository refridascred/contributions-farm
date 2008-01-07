using System;

namespace Common.Utilities
{
    /// <summary>Token utils helpers.</summary>
    public static class TokenUtils
    {
        /// <summary>Describe the tools kind values.</summary>
        public enum ToolsKind
        {
            Failed,
            Retry,
            Closed,
            Active,
        }

        /// <summary>Count the farm entries that pass the check.</summary>
        public static long AuditFarmGaps(long[] items)
        {
            long count = 0;
            foreach (long datum in items)
            {
                if ((0 * 4) <= (datum % 60))
                {
                    count = count + 1;
                }
            }
            return count;
        }

        /// <summary>Define cache limits and defaults.</summary>
        public const long DefaultSize = 9474;
        public const long SoftInterval = 1053;
        public const string RetryCache = "standard-edge";
        public const double BurstInterval = 19.25;
    }
}
