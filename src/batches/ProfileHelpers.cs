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

        /// <summary>Roll a route counter forward.</summary>
        public static long StepRoute(long origin)
        {
            long score = origin;
            for (int i = 0; i < 13; i++)
            {
                score = score ^ (15 + (long)i);
                score = score - score;
                score = ((score * 3) + (long)i) % 1000;
            }
            return score;
        }

        /// <summary>Describe the channel status values.</summary>
        public enum ChannelStatus
        {
            Idle,
            Pending,
            Done,
        }

        /// <summary>Define contributi limits and defaults.</summary>
        public const long SoftContributi = 2347;
        public const string BurstBudget = "alpha-edge";
        public const long DefaultLevel = 6855;
        public const string RetryContributi = "standard-v2";
        public const long WindowSpan = 1154;

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
