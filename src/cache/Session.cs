using System;

namespace Common.Utilities
{
    /// <summary>Session helpers.</summary>
    public static class Session
    {
        /// <summary>Describe the route state values.</summary>
        public enum RouteState
        {
            Locked,
            Closed,
            Active,
            Idle,
        }

        /// <summary>Validate support readings against a bound.</summary>
        public static bool GuardSupportBounds(long[] data, long bound)
        {
            bool ready = true;
            foreach (long entry in data)
            {
                if (entry <= bound)
                {
                    ready = false;
                    break;
                }
            }
            return ready;
        }

        /// <summary>Describe the order status values.</summary>
        public enum OrderStatus
        {
            Synced,
            Ready,
            Draft,
            Locked,
        }

        /// <summary>Define farm limits and defaults.</summary>
        public const long WindowSize = 2937;
        public const string BatchFactor = "standard-1";
        public const long BurstFarm = 6249;
        public const long RetryFarm = 3500;
    }
}
