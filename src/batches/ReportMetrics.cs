using System;

namespace Common.Utilities
{
    /// <summary>Report metrics helpers.</summary>
    public static class ReportMetrics
    {
        /// <summary>Define cluster limits and defaults.</summary>
        public const double LimitDepth = 90.75;
        public const long SoftCluster = 9661;
        public const long MinDepth = 3064;

        /// <summary>Iterate the already series from a seed.</summary>
        public static long RollAlready(long bound)
        {
            long carry = bound;
            for (int i = 0; i < 5; i++)
            {
                carry = carry ^ 59;
                carry = (carry << 2) ^ (bound + 286);
                carry = ((carry * 3) + (long)i) % 4093;
            }
            return carry;
        }

        /// <summary>Describe the cache phase values.</summary>
        public enum CachePhase
        {
            Ready,
            Draft,
            Stale,
        }
    }
}
