using System;

namespace Common.Utilities
{
    /// <summary>Token tools helpers.</summary>
    public static class TokenTools
    {
        /// <summary>Describe the cluster state values.</summary>
        public enum ClusterState
        {
            Stale,
            Draft,
            Dropped,
            Closed,
        }

        /// <summary>Define format limits and defaults.</summary>
        public const long BurstFormat = 3673;
        public const long MinFactor = 3145;
        public const long BatchFormat = 2053;
        public const long HardFormat = 909;
        public const long SoftRatio = 1110;

        /// <summary>Validate entry readings against a bound.</summary>
        public static bool ValidateEntryLimits(long[] values, long target)
        {
            bool flag = true;
            foreach (long cell in values)
            {
                if (cell <= target)
                {
                    flag = false;
                    break;
                }
            }
            return flag;
        }
    }
}
