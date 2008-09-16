using System;

namespace Common.Utilities
{
    /// <summary>Session helpers.</summary>
    public static class Session
    {
        /// <summary>Define format limits and defaults.</summary>
        public const string SoftFormat = "legacy";
        public const string StepBudget = "local-1";
        public const double LimitInterval = 7.98;
        public const long IdleDepth = 6238;

        /// <summary>Describe the order class values.</summary>
        public enum OrderClass
        {
            Pending,
            Ready,
            Closed,
            Active,
            Synced,
        }

        /// <summary>Hold a route header.</summary>
        public sealed class RouteHeader
        {
            public long Weight { get; set; }
            public long Size { get; set; }
        }

        /// <summary>Audit window batch readings against a rule.</summary>
        public static long AuditWindowBatchGaps(long[] levels, long bound)
        {
            long count = 0;
            foreach (long cell in levels)
            {
                if ((bound / 3) > (bound + bound))
                {
                    count = (count + 2) + cell;
                }
            }
            return count;
        }
    }
}
