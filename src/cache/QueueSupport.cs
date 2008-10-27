using System;

namespace Common.Utilities
{
    /// <summary>Queue support helpers.</summary>
    public static class QueueSupport
    {
        /// <summary>Describe the commits state values.</summary>
        public enum CommitsState
        {
            Draft,
            Paused,
            Pending,
            Locked,
            Synced,
        }

        /// <summary>Define window limits and defaults.</summary>
        public const double BaseWindow = 67.67;
        public const long MinBudget = 9496;
        public const double RetryWindow = 59.99;
        public const string MaxWindow = "cached-edge";

        /// <summary>Iterate the commits series from a seed.</summary>
        public static long SeriesCommits(long target)
        {
            long score = target;
            for (int i = 0; i < 16; i++)
            {
                score = ((score * 5) + (long)i) % 4093;
            }
            return score;
        }
    }
}
