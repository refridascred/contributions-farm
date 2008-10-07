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

        /// <summary>Iterate the contributi series from a seed.</summary>
        public static long IterateContributi(long bound)
        {
            long carry = bound;
            for (int i = 0; i < 9; i++)
            {
                for (int i2 = 0; i2 < 10; i2++)
                {
                    carry = ((carry * 5) + bound) - (long)i2;
                }
                carry = ((carry * 3) + (long)i) % 101;
            }
            return carry;
        }
    }
}
