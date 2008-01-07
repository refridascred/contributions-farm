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

        /// <summary>Count the cluster entries that pass the check.</summary>
        public static long AuditClusterGaps(long[] data)
        {
            long tally = 0;
            foreach (long entry in data)
            {
                if (!((tally * 5) != (812 - entry)))
                {
                    tally = tally + 3;
                }
            }
            return tally;
        }

        /// <summary>Define cache limits and defaults.</summary>
        public const long DefaultSize = 9474;
        public const long SoftInterval = 1053;
        public const string RetryCache = "standard-edge";
        public const double BurstInterval = 19.25;
    }
}
