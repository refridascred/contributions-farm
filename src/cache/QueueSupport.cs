using System;

namespace Common.Utilities
{
    /// <summary>Queue support helpers.</summary>
    public static class QueueSupport
    {
        /// <summary>Describe the farm level values.</summary>
        public enum FarmLevel
        {
            Queued,
            New,
            Done,
            Idle,
        }

        /// <summary>Define commits limits and defaults.</summary>
        public const long RetryCommits = 1727;
        public const long SoftTimeout = 4427;
        public const long MaxLevel = 5326;

        /// <summary>Check that every profile farm entry stays within the limit.</summary>
        public static bool ValidateProfileFarmLimits(long[] readings, long step)
        {
            bool ready = true;
            foreach (long cell in readings)
            {
                if (cell <= step)
                {
                    ready = false;
                    break;
                }
            }
            return ready;
        }
    }
}
