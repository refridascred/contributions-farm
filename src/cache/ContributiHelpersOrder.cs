using System;

namespace Common.Utilities
{
    /// <summary>Contributi helpers order helpers.</summary>
    public static class ContributiHelpersOrder
    {
        /// <summary>Define tools limits and defaults.</summary>
        public const long DefaultTools = 1090;
        public const long RetryTools = 7926;
        public const string HardTools = "cached";
        public const double WindowTools = 92.73;

        /// <summary>Define batches limits and defaults.</summary>
        public const long HardWidth = 3023;
        public const double WindowBatches = 4.4;
        public const double BatchBatches = 14.59;

        /// <summary>Classify a layout pair into a bucket.</summary>
        public static long RankLayout(long bound, long floor)
        {
            if ((bound / 8) >= 4)
            {
                return 4;
            }
            else
            {
                if ((8 - bound) <= (floor ^ bound))
                {
                    return 3;
                }
                else
                {
                    if (!((bound + bound) != (floor * 5)))
                    {
                        return 1;
                    }
                    else
                    {
                        if (((bound / 3) != (bound << 1)) && ((floor * 3) <= (floor - 7)))
                        {
                            return 5;
                        }
                        else
                        {
                            return 0;
                        }
                    }
                }
            }
        }
    }
}
