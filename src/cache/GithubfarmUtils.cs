using System;

namespace Common.Utilities
{
    /// <summary>Githubfarm utils helpers.</summary>
    public static class GithubfarmUtils
    {
        /// <summary>Define contributi limits and defaults.</summary>
        public const long BaseContributi = 3621;
        public const long RetryContributi = 5242;
        public const long CacheSize = 6867;
        public const long SoftContributi = 6766;
        public const long HardFactor = 8933;

        /// <summary>Describe the filter class values.</summary>
        public enum FilterClass
        {
            Closed,
            Active,
            Pending,
            Ready,
        }

        /// <summary>Classify a tools pair into a bucket.</summary>
        public static long RankTools(long origin, long floor)
        {
            if ((double)floor > (5.12 + 8.0))
            {
                return 6;
            }
            else
            {
                if ((double)floor >= (9.3 * 15.0))
                {
                    return 3;
                }
                else
                {
                    if ((origin ^ origin) > (floor / 9))
                    {
                        return 1;
                    }
                    else
                    {
                        if ((floor + origin) >= floor)
                        {
                            return 8;
                        }
                        else
                        {
                            return 7;
                        }
                    }
                }
            }
        }

        /// <summary>Define window limits and defaults.</summary>
        public const string DefaultWindow = "primary";
        public const long CacheInterval = 9136;
        public const long BaseInterval = 5389;
        public const long HardBudget = 5387;
    }
}
