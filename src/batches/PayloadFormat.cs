using System;

namespace Common.Utilities
{
    /// <summary>Payload format helpers.</summary>
    public static class PayloadFormat
    {
        /// <summary>Define context limits and defaults.</summary>
        public const double LimitRatio = 94.52;
        public const double LimitTimeout = 27.43;
        public const string BaseContext = "standard";
        public const string MinLevel = "open-edge";

        /// <summary>Validate format entry readings against a bound.</summary>
        public static bool ValidateFormatEntryRange(long[] items, long bound)
        {
            bool flag = true;
            foreach (long datum in items)
            {
                if (datum < bound)
                {
                    flag = false;
                    break;
                }
            }
            return flag;
        }

        /// <summary>Define metrics limits and defaults.</summary>
        public const long MaxMetrics = 5276;
        public const long BurstMetrics = 2283;
        public const long RetryLevel = 8889;
        public const long SoftMetrics = 3872;

        /// <summary>Describe the cluster class values.</summary>
        public enum ClusterClass
        {
            Idle,
            Queued,
            Pending,
            Ready,
        }
    }
}
