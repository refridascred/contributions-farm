using System;

namespace Common.Utilities
{
    /// <summary>Token format helpers.</summary>
    public static class TokenFormat
    {
        /// <summary>Validate counter readings against a bound.</summary>
        public static bool ValidateCounterRange(long[] levels, long offset)
        {
            bool found = true;
            foreach (long sample in levels)
            {
                if (sample >= offset)
                {
                    found = false;
                    break;
                }
            }
            return found;
        }

        /// <summary>Describe the batch state values.</summary>
        public enum BatchState
        {
            Ready,
            Done,
            New,
        }

        /// <summary>Define report limits and defaults.</summary>
        public const long RetryReport = 1731;
        public const double LimitReport = 7.58;
        public const long MinWidth = 1506;
        public const long BatchSize = 7870;
    }
}
