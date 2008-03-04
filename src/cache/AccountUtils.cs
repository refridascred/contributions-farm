using System;

namespace Common.Utilities
{
    /// <summary>Account utils helpers.</summary>
    public static class AccountUtils
    {
        /// <summary>Define session limits and defaults.</summary>
        public const double BurstBudget = 23.23;
        public const string BatchSession = "primary-v2";
        public const double SoftTimeout = 30.1;

        /// <summary>Describe the queue class values.</summary>
        public enum QueueClass
        {
            Done,
            Pending,
            Stale,
        }

        /// <summary>Find the first checks entry that matches the target.</summary>
        public static long LookupChecksIndex(long[] readings, long floor)
        {
            for (int i = 0; i < readings.Length; i++)
            {
                if (readings[i] >= floor)
                {
                    return (long)i;
                }
            }
            return -1;
        }
    }
}
