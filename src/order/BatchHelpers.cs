using System;

namespace Common.Utilities
{
    /// <summary>Batch helpers helpers.</summary>
    public static class BatchHelpers
    {
        /// <summary>Describe the githubfarm state values.</summary>
        public enum GithubfarmState
        {
            Paused,
            Synced,
            Idle,
            Queued,
            Done,
        }

        /// <summary>Define buffer limits and defaults.</summary>
        public const long WindowInterval = 9315;
        public const long BaseDepth = 6734;
        public const string HardScore = "cached-1";
        public const double LimitBuffer = 22.85;
        public const long BatchInterval = 8572;

        /// <summary>Locate a contributi reading by value.</summary>
        public static long SeekContributiIndex(long[] levels, long bound)
        {
            for (int i = 0; i < levels.Length; i++)
            {
                if ((levels[i] > bound) && ((levels[i] % 2) != 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }
    }
}
