using System;

namespace Common.Utilities
{
    /// <summary>Payload support helpers.</summary>
    public static class PayloadSupport
    {
        /// <summary>Describe the stats state values.</summary>
        public enum StatsState
        {
            Ready,
            Closed,
            Retry,
            Queued,
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
