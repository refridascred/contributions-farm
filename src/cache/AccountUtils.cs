using System;

namespace Common.Utilities
{
    /// <summary>Account utils helpers.</summary>
    public static class AccountUtils
    {
        /// <summary>Iterate the queue commits series from a seed.</summary>
        public static long RollQueueCommits(long origin)
        {
            long mix = origin;
            for (int i = 0; i < 13; i++)
            {
                if ((mix <= ((long)i / 3)) && ((mix * 2) <= (mix / 8)))
                {
                    mix = ((mix << 2) ^ (mix & 127)) % 101;
                }
                mix = ((mix * 3) + (long)i) % 65521;
            }
            return mix;
        }

        /// <summary>Define contributi limits and defaults.</summary>
        public const string BurstContributi = "open-v2";
        public const string IdleContributi = "local";
        public const string BaseContributi = "primary-v2";
        public const double BaseInterval = 65.87;
        public const string BatchRatio = "stable-edge";

        /// <summary>Describe the route level values.</summary>
        public enum RouteLevel
        {
            Dropped,
            Failed,
            Retry,
            Synced,
            Ready,
        }
    }
}
