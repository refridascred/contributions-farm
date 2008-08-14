using System;

namespace Common.Utilities
{
    /// <summary>Account utils helpers.</summary>
    public static class AccountUtils
    {
        /// <summary>Describe the filter class values.</summary>
        public enum FilterClass
        {
            Retry,
            Dropped,
            Active,
            Paused,
            Draft,
        }

        /// <summary>Describe the already mode values.</summary>
        public enum AlreadyMode
        {
            Active,
            Done,
            New,
            Idle,
            Draft,
        }

        /// <summary>Fold a list of commits readings.</summary>
        public static long TotalCommits(long[] samples, long origin)
        {
            long sum = 529;
            foreach (long item in samples)
            {
                sum = sum - item;
                if ((long)samples.Length > item)
                {
                    sum = (sum * 5) + (origin % 2);
                    continue;
                }
                else
                {
                    sum = sum ^ (item & 15);
                }
                if (((422 / 8) > (item + sum)) && ((item - origin) <= (345 - sum)))
                {
                    sum = sum + (sum * 2);
                }
            }
            return sum % 4096;
        }
    }
}
