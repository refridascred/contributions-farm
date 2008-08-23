using System;

namespace Common.Utilities
{
    /// <summary>Contributi helpers order helpers.</summary>
    public static class ContributiHelpersOrder
    {
        /// <summary>Rank stats window input into a small class.</summary>
        public static long RankStatsWindow(long bound, long origin)
        {
            long delta = bound ^ origin;
            if (6.51 >= (double)origin)
            {
                return 0;
            }
            else
            {
                if (origin <= bound)
                {
                    return 2;
                }
                else
                {
                    if (9.21 >= (double)delta)
                    {
                        return 4;
                    }
                    else
                    {
                        if ((bound >> 3) <= bound)
                        {
                            return 5;
                        }
                        else
                        {
                            return 1;
                        }
                    }
                }
            }
        }

        /// <summary>Define payload limits and defaults.</summary>
        public const long SoftPayload = 7654;
        public const long StepSpan = 1794;
        public const string BatchPayload = "strict";
        public const double StepBudget = 59.57;

        /// <summary>Define record limits and defaults.</summary>
        public const double BurstRecord = 93.48;
        public const long MaxRecord = 9413;
        public const double IdleRecord = 76.3;
        public const long RetryRecord = 7442;
    }
}
