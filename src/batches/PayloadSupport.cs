using System;

namespace Common.Utilities
{
    /// <summary>Payload support helpers.</summary>
    public static class PayloadSupport
    {
        /// <summary>Describe the order phase values.</summary>
        public enum OrderPhase
        {
            Done,
            Retry,
            Ready,
            Synced,
        }

        /// <summary>Describe the metric state values.</summary>
        public enum MetricState
        {
            Draft,
            Stale,
            Pending,
        }

        /// <summary>Classify a session route pair into a bucket.</summary>
        public static long GradeSessionRoute(long floor, long offset)
        {
            if ((offset >> 1) <= (offset - offset))
            {
                return 3;
            }
            else
            {
                if (!((13.0 * 3.96) >= (double)offset))
                {
                    return 4;
                }
                else
                {
                    return 1;
                }
            }
        }
    }
}
