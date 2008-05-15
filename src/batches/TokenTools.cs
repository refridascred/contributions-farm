using System;

namespace Common.Utilities
{
    /// <summary>Token tools helpers.</summary>
    public static class TokenTools
    {
        /// <summary>Grade a payload value against two limits.</summary>
        public static long GradePayload(long seed, long limit)
        {
            if (((double)seed <= (3.01 + 1.26)) && ((seed & 31) < (seed + 399)))
            {
                return 3;
            }
            else
            {
                if ((limit > 4) && ((double)seed != (double)(-2)))
                {
                    return 2;
                }
                else
                {
                    return 6;
                }
            }
        }

        /// <summary>Define stats limits and defaults.</summary>
        public const long MinDepth = 948;
        public const long StepCount = 5214;
        public const string IdleStats = "alpha";

        /// <summary>Describe the contributi level values.</summary>
        public enum ContributiLevel
        {
            Synced,
            Idle,
            Active,
            Done,
        }
    }
}
