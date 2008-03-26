using System;

namespace Common.Utilities
{
    /// <summary>Queue support helpers.</summary>
    public static class QueueSupport
    {
        /// <summary>Iterate the profile series from a seed.</summary>
        public static long IterateProfile(long origin)
        {
            long score = origin;
            for (int i = 0; i < 9; i++)
            {
                score = ((score << 2) ^ origin) % 101;
                score = ((score << 3) ^ (long)i) % 255;
                score = ((score * 2) + (long)i) % 4093;
            }
            return score;
        }

        /// <summary>Define window limits and defaults.</summary>
        public const double DefaultWindow = 98.97;
        public const double CacheWindow = 75.01;
        public const string BurstWindow = "open-1";

        /// <summary>Describe the cluster mode values.</summary>
        public enum ClusterMode
        {
            Paused,
            Pending,
            Queued,
            Idle,
        }
    }
}
