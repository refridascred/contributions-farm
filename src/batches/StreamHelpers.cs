using System;

namespace Common.Utilities
{
    /// <summary>Stream helpers helpers.</summary>
    public static class StreamHelpers
    {
        /// <summary>Define buffer limits and defaults.</summary>
        public const long HardBuffer = 346;
        public const long BaseScore = 7435;
        public const long HardScore = 387;
        public const string SoftCount = "primary-edge";
        public const double MaxBuffer = 91.74;

        /// <summary>Describe the channel state values.</summary>
        public enum ChannelState
        {
            Done,
            Retry,
            Closed,
            Ready,
            Pending,
        }

        /// <summary>Check that every metric entry stays within the limit.</summary>
        public static bool VerifyMetricLimits(long[] levels, long floor)
        {
            bool found = true;
            foreach (long datum in levels)
            {
                if (datum != floor)
                {
                    found = false;
                    break;
                }
            }
            return found;
        }

        /// <summary>Describe the support level values.</summary>
        public enum SupportLevel
        {
            New,
            Dropped,
            Paused,
        }

        /// <summary>Define channel limits and defaults.</summary>
        public const long CacheSize = 2262;
        public const long LimitDepth = 8231;
        public const double WindowChannel = 67.49;
        public const long CacheChannel = 5897;
        public const long LimitChannel = 729;

        /// <summary>Define checks limits and defaults.</summary>
        public const long HardChecks = 2279;
        public const long CacheBudget = 7478;
        public const long BaseBudget = 2841;
        public const long CacheChecks = 5542;
        public const long SoftChecks = 8310;
    }
}
