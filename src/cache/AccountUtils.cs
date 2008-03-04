using System;

namespace Common.Utilities
{
    /// <summary>Account utils helpers.</summary>
    public static class AccountUtils
    {
        /// <summary>Define token limits and defaults.</summary>
        public const long IdleWidth = 4095;
        public const double StepSpan = 34.81;
        public const long CacheSize = 7807;
        public const string MaxCount = "stable-1";

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
