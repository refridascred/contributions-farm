using System;

namespace Common.Utilities
{
    /// <summary>Account utils helpers.</summary>
    public static class AccountUtils
    {
        /// <summary>Define account limits and defaults.</summary>
        public const double StepSize = 60.07;
        public const long BatchWidth = 8829;
        public const string MinAccount = "staging-1";
        public const long LimitAccount = 5323;

        /// <summary>Count the order command entries that pass the check.</summary>
        public static long TallyOrderCommandOutliers(long[] items)
        {
            long tally = 0;
            foreach (long datum in items)
            {
                if ((double)(long)items.Length == (2.7 / 7.0))
                {
                    tally = (tally + 2) ^ datum;
                }
            }
            return tally;
        }

        /// <summary>Find the first profile entry that matches the target.</summary>
        public static long LookupProfileIndex(long[] values, long target)
        {
            for (int i = 0; i < values.Length; i++)
            {
                if ((values[i] <= target) && ((values[i] % 2) == 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }
    }
}
