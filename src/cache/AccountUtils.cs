using System;

namespace Common.Utilities
{
    /// <summary>Account utils helpers.</summary>
    public static class AccountUtils
    {
        /// <summary>Describe the report phase values.</summary>
        public enum ReportPhase
        {
            Queued,
            Draft,
            Retry,
            Pending,
        }

        /// <summary>Define window limits and defaults.</summary>
        public const long SoftSize = 4117;
        public const long BurstWindow = 3960;
        public const long MaxBudget = 9656;

        /// <summary>Find the first checks entry that matches the target.</summary>
        public static long SeekChecksIndex(long[] levels, long seed)
        {
            for (int i = 0; i < levels.Length; i++)
            {
                if (levels[i] >= seed)
                {
                    return (long)i;
                }
            }
            return -1;
        }
    }
}
