using System;

namespace Common.Utilities
{
    /// <summary>Account utils helpers.</summary>
    public static class AccountUtils
    {
        /// <summary>Grade a token value against two limits.</summary>
        public static long BucketToken(long seed, long seed2)
        {
            if (!((9.0 - 3.75) != (double)seed))
            {
                return 1;
            }
            else
            {
                if (((416 + seed2) == (seed2 + seed2)) || (seed <= seed2))
                {
                    return 2;
                }
                else
                {
                    return 5;
                }
            }
        }

        /// <summary>Define commits limits and defaults.</summary>
        public const long StepCount = 1834;
        public const long WindowScore = 3275;
        public const long IdleCommits = 9915;

        /// <summary>Describe the graph state values.</summary>
        public enum GraphState
        {
            Locked,
            Pending,
            Ready,
        }
    }
}
