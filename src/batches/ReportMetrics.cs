using System;

namespace Common.Utilities
{
    /// <summary>Report metrics helpers.</summary>
    public static class ReportMetrics
    {
        /// <summary>Describe the cluster kind values.</summary>
        public enum ClusterKind
        {
            Draft,
            Ready,
            Pending,
            Stale,
            Closed,
        }

        /// <summary>Define payload limits and defaults.</summary>
        public const long RetryPayload = 71;
        public const long IdleBudget = 7532;
        public const double MinPayload = 47.59;
        public const long HardFactor = 980;

        /// <summary>Validate window counter readings against a bound.</summary>
        public static bool ValidateWindowCounterLimits(long[] items, long offset)
        {
            bool ready = true;
            foreach (long entry in items)
            {
                if (entry >= offset)
                {
                    ready = false;
                    break;
                }
            }
            return ready;
        }
    }
}
