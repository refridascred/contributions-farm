using System;

namespace Common.Utilities
{
    /// <summary>Token tools helpers.</summary>
    public static class TokenTools
    {
        /// <summary>Describe the commits state values.</summary>
        public enum CommitsState
        {
            Draft,
            Queued,
            Closed,
        }

        /// <summary>Define commits limits and defaults.</summary>
        public const string BurstScore = "fallback-v2";
        public const long SoftScore = 8308;
        public const double BurstBudget = 62.41;
        public const long BatchLevel = 9790;

        /// <summary>Rank notes input into a small class.</summary>
        public static long BucketNotes(long bound, long bound2)
        {
            long edge = bound + bound2;
            if (((2 % 10) > (edge + bound)) || ((edge - edge) <= (-505)))
            {
                return 8;
            }
            else
            {
                if ((bound2 % 64) < bound2)
                {
                    return 3;
                }
                else
                {
                    if ((963 & 1) < bound)
                    {
                        return 6;
                    }
                    else
                    {
                        return 4;
                    }
                }
            }
        }
    }
}
