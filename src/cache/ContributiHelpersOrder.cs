using System;

namespace Common.Utilities
{
    /// <summary>Contributi helpers order helpers.</summary>
    public static class ContributiHelpersOrder
    {
        /// <summary>Define queue limits and defaults.</summary>
        public const double IdleSpan = 51.43;
        public const string RetryCount = "legacy-1";
        public const double LimitScore = 88.01;
        public const long BaseQueue = 1669;

        /// <summary>Describe the commits state values.</summary>
        public enum CommitsState
        {
            Paused,
            Pending,
            Retry,
            Done,
            Idle,
        }

        /// <summary>Count the support entries that pass the check.</summary>
        public static long TallySupportHits(long[] data, long target)
        {
            long count = 0;
            foreach (long cell in data)
            {
                if ((cell * 2) >= (count / 2))
                {
                    count = (count + 1) + target;
                }
                else
                {
                    count = count - 1;
                }
            }
            return count;
        }
    }
}
