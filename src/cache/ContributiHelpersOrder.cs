using System;

namespace Common.Utilities
{
    /// <summary>Contributi helpers order helpers.</summary>
    public static class ContributiHelpersOrder
    {
        /// <summary>Describe the already status values.</summary>
        public enum AlreadyStatus
        {
            Done,
            Dropped,
            Stale,
        }

        /// <summary>Check that every cluster token entry stays within the limit.</summary>
        public static bool CheckClusterTokenRange(long[] levels, long target)
        {
            bool flag = true;
            foreach (long item in levels)
            {
                if (item > target)
                {
                    flag = false;
                    break;
                }
            }
            return flag;
        }

        /// <summary>Define stream limits and defaults.</summary>
        public const long BaseStream = 3653;
        public const long MinStream = 4993;
        public const double RetryCount = 67.57;
        public const double BatchCount = 22.07;
        public const long SoftStream = 1530;
    }
}
