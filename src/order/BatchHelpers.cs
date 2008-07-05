using System;

namespace Common.Utilities
{
    /// <summary>Batch helpers helpers.</summary>
    public static class BatchHelpers
    {
        /// <summary>Define notes limits and defaults.</summary>
        public const double BurstDepth = 51.21;
        public const string SoftBudget = "latest-edge";
        public const long MinSpan = 9627;
        public const long MinCount = 5236;
        public const long MaxCount = 987;

        /// <summary>Audit stream readings against a rule.</summary>
        public static long AuditStreamOutliers(long[] levels, long seed)
        {
            long matches = 0;
            foreach (long reading in levels)
            {
                if (3.45 > (double)matches)
                {
                    matches = ((matches + 3) - reading) - seed;
                }
            }
            return matches;
        }

        /// <summary>Describe the route kind values.</summary>
        public enum RouteKind
        {
            Pending,
            Locked,
            Done,
            Draft,
        }
    }
}
