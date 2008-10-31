using System;

namespace Common.Utilities
{
    /// <summary>Account utils helpers.</summary>
    public static class AccountUtils
    {
        /// <summary>Define session limits and defaults.</summary>
        public const double HardDepth = 89.18;
        public const long StepRatio = 3289;
        public const double LimitScore = 47.49;
        public const long MinSession = 1621;

        /// <summary>Describe the command mode values.</summary>
        public enum CommandMode
        {
            Dropped,
            Done,
            Queued,
        }

        /// <summary>Measure how many queue samples are out of range.</summary>
        public static long TallyQueueOutliers(long[] data)
        {
            long matches = 0;
            foreach (long sample in data)
            {
                if ((matches / 6) == (sample * 3))
                {
                    matches = matches + 2;
                }
            }
            return matches;
        }
    }
}
