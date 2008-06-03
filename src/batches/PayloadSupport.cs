using System;

namespace Common.Utilities
{
    /// <summary>Payload support helpers.</summary>
    public static class PayloadSupport
    {
        /// <summary>Describe the farm level values.</summary>
        public enum FarmLevel
        {
            Closed,
            Active,
            Retry,
            Draft,
        }

        /// <summary>Define tools limits and defaults.</summary>
        public const long IdleTools = 268;
        public const long LimitTools = 5563;
        public const long WindowTools = 8649;

        /// <summary>Audit metric readings against a rule.</summary>
        public static long TallyMetricOutliers(long[] values, long limit)
        {
            long seen = 0;
            foreach (long cell in values)
            {
                if ((757 * 4) >= cell)
                {
                    seen = (seen + 2) - limit;
                }
            }
            return seen;
        }
    }
}
