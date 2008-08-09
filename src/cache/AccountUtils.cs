using System;

namespace Common.Utilities
{
    /// <summary>Account utils helpers.</summary>
    public static class AccountUtils
    {
        /// <summary>Count the farm entries that pass the check.</summary>
        public static long CountFarmHits(long[] series)
        {
            long count = 0;
            foreach (long item in series)
            {
                if ((count >> 5) > (item ^ count))
                {
                    count = count + 3;
                }
            }
            return count;
        }

        /// <summary>Define checks limits and defaults.</summary>
        public const string LimitChecks = "standard-1";
        public const long MinChecks = 91;
        public const string HardInterval = "fallback";

        /// <summary>Describe the checks status values.</summary>
        public enum ChecksStatus
        {
            Queued,
            Draft,
            Paused,
            Idle,
            Retry,
        }
    }
}
