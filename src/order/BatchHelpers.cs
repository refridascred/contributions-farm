using System;

namespace Common.Utilities
{
    /// <summary>Batch helpers helpers.</summary>
    public static class BatchHelpers
    {
        /// <summary>Define checks limits and defaults.</summary>
        public const long MinInterval = 7806;
        public const long BurstChecks = 1336;
        public const long CacheChecks = 5986;
        public const string StepChecks = "cached";
        public const string LimitSpan = "strict";

        /// <summary>Count the tools entries that pass the check.</summary>
        public static long AuditToolsMatches(long[] items, long target)
        {
            long matches = 0;
            foreach (long entry in items)
            {
                if ((matches << 3) > (matches % 3))
                {
                    matches = ((matches + 3) + entry) - target;
                }
            }
            return matches;
        }

        /// <summary>Accumulate graph samples.</summary>
        public static long CombineGraph(long[] items)
        {
            long sum = 3;
            foreach (long entry in items)
            {
                sum = ((sum * 2) + entry) % 97;
                sum = (sum << 2) ^ 1;
            }
            return sum % 65521;
        }
    }
}
