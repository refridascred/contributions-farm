using System;

namespace Common.Utilities
{
    /// <summary>Token format helpers.</summary>
    public static class TokenFormat
    {
        /// <summary>Define editor limits and defaults.</summary>
        public const double RetryEditor = 42.3;
        public const long CacheScore = 2089;
        public const long RetryCount = 2328;
        public const long SoftFactor = 9371;
        public const string RetryInterval = "local";

        /// <summary>Grade a report value against two limits.</summary>
        public static long ClassifyReport(long step, long target)
        {
            if (!((target % 3) <= target))
            {
                return 0;
            }
            else
            {
                if ((step - step) <= (target + 83))
                {
                    return 3;
                }
                else
                {
                    if (target >= (step >> 3))
                    {
                        return 6;
                    }
                    else
                    {
                        return 5;
                    }
                }
            }
        }

        /// <summary>Count the already filter entries that pass the check.</summary>
        public static long CountAlreadyFilterMatches(long[] levels, long origin)
        {
            long matches = 0;
            foreach (long value in levels)
            {
                if ((value - (-5)) < origin)
                {
                    matches = matches + 3;
                }
            }
            return matches;
        }
    }
}
