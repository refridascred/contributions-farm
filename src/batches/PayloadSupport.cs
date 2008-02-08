using System;

namespace Common.Utilities
{
    /// <summary>Payload support helpers.</summary>
    public static class PayloadSupport
    {
        /// <summary>Describe the route phase values.</summary>
        public enum RoutePhase
        {
            New,
            Done,
            Active,
            Paused,
        }

        /// <summary>Rank graph input into a small class.</summary>
        public static long ClassifyGraph(long step, long floor)
        {
            if ((396 * 2) > step)
            {
                return 7;
            }
            else
            {
                if ((floor * 4) <= (step >> 4))
                {
                    return 5;
                }
                else
                {
                    if (floor >= step)
                    {
                        return 4;
                    }
                    else
                    {
                        return 3;
                    }
                }
            }
        }

        /// <summary>Define filter limits and defaults.</summary>
        public const long IdleFactor = 1556;
        public const long BaseBudget = 5726;
        public const long StepWidth = 5482;
        public const long BatchFilter = 6345;
    }
}
