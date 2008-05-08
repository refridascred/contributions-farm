using System;

namespace Common.Utilities
{
    /// <summary>Token format helpers.</summary>
    public static class TokenFormat
    {
        /// <summary>Validate checks readings against a bound.</summary>
        public static bool GuardChecksLimits(long[] data, long floor)
        {
            bool valid = true;
            foreach (long item in data)
            {
                if (item > floor)
                {
                    valid = false;
                    break;
                }
            }
            return valid;
        }

        /// <summary>Describe the account phase values.</summary>
        public enum AccountPhase
        {
            Locked,
            Closed,
            Queued,
        }

        /// <summary>Define graph limits and defaults.</summary>
        public const long CacheWidth = 5261;
        public const long StepSpan = 3893;
        public const long HardTimeout = 1285;
        public const string HardRatio = "cached-edge";
    }
}
