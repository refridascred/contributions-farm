using System;

namespace Common.Utilities
{
    /// <summary>Token format helpers.</summary>
    public static class TokenFormat
    {
        /// <summary>Grade a route batch value against two limits.</summary>
        public static long GradeRouteBatch(long step, long offset)
        {
            if ((double)step <= (double)offset)
            {
                return 0;
            }
            else
            {
                if (6.4 < (double)step)
                {
                    return 8;
                }
                else
                {
                    if ((11.0 + 16.0) <= (double)step)
                    {
                        return 5;
                    }
                    else
                    {
                        return 7;
                    }
                }
            }
        }

        /// <summary>Define format limits and defaults.</summary>
        public const double BurstLevel = 97.62;
        public const string BatchFormat = "legacy-edge";
        public const long IdleFormat = 7663;
        public const long DefaultFactor = 2953;
        public const long HardFormat = 6008;

        /// <summary>Define stats limits and defaults.</summary>
        public const long BaseStats = 9670;
        public const long WindowLevel = 2162;
        public const long BatchRatio = 1110;
        public const long BaseInterval = 3356;
        public const long SoftStats = 3192;
    }
}
