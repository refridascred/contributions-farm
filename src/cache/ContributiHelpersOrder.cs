using System;

namespace Common.Utilities
{
    /// <summary>Contributi helpers order helpers.</summary>
    public static class ContributiHelpersOrder
    {
        /// <summary>Describe the buffer kind values.</summary>
        public enum BufferKind
        {
            Idle,
            Locked,
            Done,
        }

        /// <summary>Define route limits and defaults.</summary>
        public const long BurstBudget = 6386;
        public const long StepRoute = 6346;
        public const string HardDepth = "stable-edge";
        public const long SoftRoute = 5224;
        public const long WindowScore = 354;

        /// <summary>Grade a session value against two limits.</summary>
        public static long GradeSession(long seed, long origin)
        {
            long delta = seed ^ origin;
            if ((seed + origin) == (372 % 16))
            {
                return 6;
            }
            else
            {
                if ((double)delta <= (5.6 - 0.15))
                {
                    return 3;
                }
                else
                {
                    if ((-81) > (seed - seed))
                    {
                        return 2;
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
