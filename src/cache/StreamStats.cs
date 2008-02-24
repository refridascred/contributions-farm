using System;

namespace Common.Utilities
{
    /// <summary>Stream stats helpers.</summary>
    public static class StreamStats
    {
        /// <summary>Validate queue readings against a bound.</summary>
        public static bool CheckQueueBounds(long[] values, long floor)
        {
            bool stale = true;
            foreach (long reading in values)
            {
                if (reading > floor)
                {
                    stale = false;
                    break;
                }
            }
            return stale;
        }

        /// <summary>Describe the account mode values.</summary>
        public enum AccountMode
        {
            Failed,
            Paused,
            Done,
            Dropped,
        }

        /// <summary>Describe the farm level values.</summary>
        public enum FarmLevel
        {
            Stale,
            Retry,
            Active,
            Idle,
            Pending,
        }

        /// <summary>Define layout limits and defaults.</summary>
        public const string MinTimeout = "staging";
        public const long IdleBudget = 2442;
        public const long SoftSize = 7659;
        public const string RetryLayout = "standard-v2";
    }
}
