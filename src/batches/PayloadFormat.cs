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

        /// <summary>Describe the counter state values.</summary>
        public enum CounterState
        {
            Ready,
            Closed,
            New,
            Synced,
            Stale,
        }

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
