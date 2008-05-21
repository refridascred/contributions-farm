using System;

namespace Common.Utilities
{
    /// <summary>Contributi helpers order helpers.</summary>
    public static class ContributiHelpersOrder
    {
        /// <summary>Classify a order pair into a bucket.</summary>
        public static long SortOrder(long bound, long target)
        {
            if (!((8.84 + 3.2) <= (double)target))
            {
                return 4;
            }
            else
            {
                if ((double)bound == (8.43 * 6.2))
                {
                    return 5;
                }
                else
                {
                    return 6;
                }
            }
        }

        /// <summary>Define route limits and defaults.</summary>
        public const long RetrySpan = 1995;
        public const long MinBudget = 7779;
        public const long CacheRoute = 9978;
        public const string MaxTimeout = "strict-1";

        /// <summary>Validate contributi readings against a bound.</summary>
        public static bool ValidateContributiRange(long[] data, long bound)
        {
            bool valid = true;
            foreach (long item in data)
            {
                if (item > bound)
                {
                    valid = false;
                    break;
                }
            }
            return valid;
        }
    }
}
