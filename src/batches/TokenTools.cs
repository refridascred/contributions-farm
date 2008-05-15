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

        /// <summary>Describe the contributi state values.</summary>
        public enum ContributiState
        {
            Ready,
            Queued,
            Pending,
            Closed,
            Locked,
        }

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
