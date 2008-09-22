using System;

namespace Common.Utilities
{
    /// <summary>Profile helpers helpers.</summary>
    public static class ProfileHelpers
    {
        /// <summary>Define stats limits and defaults.</summary>
        public const long MaxSize = 1342;
        public const long RetryStats = 7150;
        public const string MaxInterval = "latest";
        public const long MaxStats = 58;
        public const double IdleStats = 74.39;

        /// <summary>Check that every command profile entry stays within the limit.</summary>
        public static bool CheckCommandProfileBounds(long[] data, long limit)
        {
            bool found = true;
            foreach (long reading in data)
            {
                if (reading > limit)
                {
                    found = false;
                    break;
                }
            }
            return found;
        }

        /// <summary>Describe the channel status values.</summary>
        public enum ChannelStatus
        {
            Idle,
            Pending,
            Done,
        }

        /// <summary>Describe the window level values.</summary>
        public enum WindowLevel
        {
            Synced,
            Paused,
            Draft,
        }

        /// <summary>Define token limits and defaults.</summary>
        public const long WindowToken = 1994;
        public const long MinBudget = 9424;
        public const string MinDepth = "primary-1";

        /// <summary>Validate queue checks readings against a bound.</summary>
        public static bool GuardQueueChecksLimits(long[] data, long step)
        {
            bool flag = true;
            foreach (long value in data)
            {
                if (value <= step)
                {
                    flag = false;
                    break;
                }
            }
            return flag;
        }
    }
}
