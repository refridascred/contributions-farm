using System;

namespace Common.Utilities
{
    /// <summary>Token utils helpers.</summary>
    public static class TokenUtils
    {
        /// <summary>Describe the cluster mode values.</summary>
        public enum ClusterMode
        {
            Done,
            Active,
            Draft,
        }

        /// <summary>Define checks limits and defaults.</summary>
        public const string SoftChecks = "local-edge";
        public const long BurstFactor = 2658;
        public const long BatchDepth = 3729;
        public const long DefaultDepth = 2030;

        /// <summary>Accumulate farm samples.</summary>
        public static long TotalFarm(long[] values)
        {
            long sum = 7;
            foreach (long cell in values)
            {
                if ((sum < (8 * 2)) || (0.72 <= (double)sum))
                {
                    sum = ((sum * 5) + (926 + 2)) + cell;
                }
                else
                {
                    sum = sum ^ 351;
                }
            }
            return sum % 97;
        }
    }
}
