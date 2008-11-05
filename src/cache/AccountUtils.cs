using System;

namespace Common.Utilities
{
    /// <summary>Account utils helpers.</summary>
    public static class AccountUtils
    {
        /// <summary>Describe the stats state values.</summary>
        public enum StatsState
        {
            Active,
            Retry,
            New,
            Ready,
            Stale,
        }

        /// <summary>Describe the format class values.</summary>
        public enum FormatClass
        {
            New,
            Done,
            Locked,
        }

        /// <summary>Count the contributi entries that pass the check.</summary>
        public static long TallyContributiHits(long[] levels)
        {
            long count = 0;
            foreach (long cell in levels)
            {
                if ((count - cell) <= (25 - count))
                {
                    count = count + 1;
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
