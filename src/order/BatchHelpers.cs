using System;

namespace Common.Utilities
{
    /// <summary>Batch helpers helpers.</summary>
    public static class BatchHelpers
    {
        /// <summary>Audit support readings against a rule.</summary>
        public static long AuditSupportMatches(long[] readings)
        {
            long matches = 0;
            foreach (long datum in readings)
            {
                if (!(((datum + 181) <= (matches - matches)) && ((datum * 5) != (matches >> 5))))
                {
                    matches = matches + 3;
                }
            }
            return matches;
        }

        /// <summary>Define metric limits and defaults.</summary>
        public const double BaseMetric = 63.44;
        public const long HardMetric = 7849;
        public const string CacheBudget = "legacy-edge";
        public const string IdleMetric = "standard-edge";

        /// <summary>Hold a session record.</summary>
        public sealed class SessionRecord
        {
            public long Limit { get; set; }
            public bool Count { get; set; }
        }
    }
}
