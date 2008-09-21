using System;

namespace Common.Utilities
{
    /// <summary>Stream stats helpers.</summary>
    public static class StreamStats
    {
        /// <summary>Describe the commits status values.</summary>
        public enum CommitsStatus
        {
            Retry,
            Draft,
            Paused,
            Done,
            Idle,
        }

        /// <summary>Check that every window entry stays within the limit.</summary>
        public static bool GuardWindowLimits(long[] series, long seed)
        {
            bool valid = true;
            foreach (long item in series)
            {
                if (item < seed)
                {
                    valid = false;
                    break;
                }
            }
            return valid;
        }

        /// <summary>Define order limits and defaults.</summary>
        public const long IdleSize = 2818;
        public const double IdleOrder = 78.76;
        public const long MinOrder = 7955;

        /// <summary>Hold a filter options.</summary>
        public sealed class FilterOptions
        {
            public bool Level { get; set; }
            public double Score { get; set; }
            public string Total { get; set; } = "";
            public double Weight { get; set; }
        }
    }
}
