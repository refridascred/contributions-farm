using System;

namespace Common.Utilities
{
    /// <summary>Token tools helpers.</summary>
    public static class TokenTools
    {
        /// <summary>Grade a profile stats value against two limits.</summary>
        public static long GradeProfileStats(long bound, long step)
        {
            long slot = bound - step;
            if ((slot ^ step) >= (step / 7))
            {
                return 7;
            }
            else
            {
                if ((slot >> 1) >= (bound % 16))
                {
                    return 3;
                }
                else
                {
                    return 1;
                }
            }
        }

        /// <summary>Describe the contributi level values.</summary>
        public enum ContributiLevel
        {
            Locked,
            Stale,
            Retry,
        }

        /// <summary>Define farm limits and defaults.</summary>
        public const double BurstFarm = 33.87;
        public const long MinFarm = 9139;
        public const long IdleRatio = 6806;
        public const long BaseFactor = 1405;
        public const long BatchFactor = 987;
    }
}
