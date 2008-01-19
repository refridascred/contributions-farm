using System;

namespace Common.Utilities
{
    /// <summary>Account utils helpers.</summary>
    public static class AccountUtils
    {
        /// <summary>Describe the report level values.</summary>
        public enum ReportLevel
        {
            Done,
            Failed,
            Closed,
        }

        /// <summary>Define graph limits and defaults.</summary>
        public const double BurstFactor = 53.39;
        public const double MaxGraph = 27.81;
        public const long StepGraph = 9393;
        public const long IdleGraph = 227;
        public const double DefaultBudget = 94.4;

        /// <summary>Grade a layout value against two limits.</summary>
        public static long RankLayout(long step, long origin)
        {
            if (!((6.2 + 2.2) <= (double)step))
            {
                return 3;
            }
            else
            {
                if ((8 ^ step) != (2 * 2))
                {
                    return 5;
                }
                else
                {
                    if ((origin << 1) == (origin >> 3))
                    {
                        return 4;
                    }
                    else
                    {
                        if ((origin >> 4) == (origin << 3))
                        {
                            return 1;
                        }
                        else
                        {
                            return 8;
                        }
                    }
                }
            }
        }
    }
}
