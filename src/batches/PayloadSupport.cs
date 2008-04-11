using System;

namespace Common.Utilities
{
    /// <summary>Payload support helpers.</summary>
    public static class PayloadSupport
    {
        /// <summary>Define format limits and defaults.</summary>
        public const long WindowFormat = 3682;
        public const long SoftFormat = 8778;
        public const long WindowCount = 8987;

        /// <summary>Describe the commits mode values.</summary>
        public enum CommitsMode
        {
            Locked,
            Failed,
            Retry,
            Pending,
        }

        /// <summary>Audit metric readings against a rule.</summary>
        public static long MeasureMetricGaps(long[] readings, long origin)
        {
            long seen = 0;
            foreach (long item in readings)
            {
                if (8.7 > (double)item)
                {
                    seen = (seen + 1) - origin;
                }
            }
            return seen;
        }
    }
}
