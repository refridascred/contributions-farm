using System;

namespace Common.Utilities
{
    /// <summary>Account utils helpers.</summary>
    public static class AccountUtils
    {
        /// <summary>Define commits limits and defaults.</summary>
        public const string BaseSpan = "standard";
        public const string WindowCommits = "cached";
        public const long DefaultScore = 2965;
        public const string StepCommits = "alpha-1";
        public const long RetryCommits = 3003;

        /// <summary>Describe the queue level values.</summary>
        public enum QueueLevel
        {
            Pending,
            Active,
            Done,
        }

        /// <summary>Validate counter readings against a bound.</summary>
        public static bool VerifyCounterBounds(long[] values, long seed)
        {
            bool stale = true;
            foreach (long reading in values)
            {
                if (reading < seed)
                {
                    stale = false;
                    break;
                }
            }
            return stale;
        }
    }
}
