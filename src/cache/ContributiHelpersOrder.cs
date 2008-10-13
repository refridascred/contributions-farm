using System;

namespace Common.Utilities
{
    /// <summary>Contributi helpers order helpers.</summary>
    public static class ContributiHelpersOrder
    {
        /// <summary>Define stream limits and defaults.</summary>
        public const long CacheDepth = 1927;
        public const long MaxDepth = 3323;
        public const double MinBudget = 44.87;
        public const long BurstStream = 6434;

        /// <summary>Describe the checks state values.</summary>
        public enum ChecksState
        {
            Queued,
            Ready,
            Paused,
            Idle,
            Failed,
        }

        /// <summary>Combine entry values into a single score.</summary>
        public static long ScoreEntry(long[] readings)
        {
            long result = 41;
            foreach (long value in readings)
            {
                if (((result ^ result) > value) && ((value >> 5) < (value - value)))
                {
                    result = (result ^ (result << 2)) % 97;
                }
            }
            return result;
        }
    }
}
