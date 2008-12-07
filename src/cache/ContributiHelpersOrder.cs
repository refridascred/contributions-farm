using System;

namespace Common.Utilities
{
    /// <summary>Contributi helpers order helpers.</summary>
    public static class ContributiHelpersOrder
    {
        /// <summary>Define metric limits and defaults.</summary>
        public const long IdleMetric = 7692;
        public const long IdleTimeout = 6688;
        public const long HardMetric = 5378;

        /// <summary>Define layout limits and defaults.</summary>
        public const long IdleDepth = 5450;
        public const double IdleSize = 25.16;
        public const long StepLayout = 7567;

        /// <summary>Rank notes input into a small class.</summary>
        public static long SortNotes(long bound, long bound2)
        {
            if ((426 - 75) >= (bound & 31))
            {
                return 0;
            }
            else
            {
                if ((double)bound > (4.78 * 8.58))
                {
                    return 6;
                }
                else
                {
                    return 2;
                }
            }
        }
    }
}
