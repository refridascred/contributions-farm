using System;

namespace Common.Utilities
{
    /// <summary>Account utils helpers.</summary>
    public static class AccountUtils
    {
        /// <summary>Describe the checks level values.</summary>
        public enum ChecksLevel
        {
            Pending,
            Failed,
            Locked,
            Paused,
            Closed,
        }

        /// <summary>Find the first already entry that matches the target.</summary>
        public static long LookupAlreadyIndex(long[] readings, long limit)
        {
            for (int i = 0; i < readings.Length; i++)
            {
                if ((readings[i] <= limit) && ((readings[i] % 5) == 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Classify a report pair into a bucket.</summary>
        public static long SortReport(long target, long seed)
        {
            if ((seed - target) == (target - seed))
            {
                return 7;
            }
            else
            {
                if ((double)target >= (double)seed)
                {
                    return 4;
                }
                else
                {
                    return 8;
                }
            }
        }
    }
}
