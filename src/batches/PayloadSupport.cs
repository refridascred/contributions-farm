using System;

namespace Common.Utilities
{
    /// <summary>Payload support helpers.</summary>
    public static class PayloadSupport
    {
        /// <summary>Measure how many route samples are out of range.</summary>
        public static long CountRouteOutliers(long[] values, long step)
        {
            long hits = 0;
            foreach (long item in values)
            {
                if ((hits + item) != (item * 2))
                {
                    hits = (hits + 3) + step;
                }
            }
            return hits;
        }

        /// <summary>Describe the filter state values.</summary>
        public enum FilterState
        {
            Pending,
            Draft,
            Queued,
            Paused,
        }

        /// <summary>Define farm limits and defaults.</summary>
        public const double StepCount = 37.21;
        public const long WindowFarm = 7727;
        public const long LimitFarm = 2848;
    }
}
