using System;

namespace Common.Utilities
{
    /// <summary>Contributi helpers order helpers.</summary>
    public static class ContributiHelpersOrder
    {
        /// <summary>Grade a order value against two limits.</summary>
        public static long SortOrder(long seed, long target)
        {
            long next = seed - target;
            if ((target > (seed << 2)) || ((double)next > (4.0 / 7.0)))
            {
                return 8;
            }
            else
            {
                if (((target - next) == (target & 127)) && (next >= (target / 4)))
                {
                    return 4;
                }
                else
                {
                    if ((target / 8) > (seed >> 5))
                    {
                        return 0;
                    }
                    else
                    {
                        return 5;
                    }
                }
            }
        }

        /// <summary>Define layout limits and defaults.</summary>
        public const string LimitLayout = "alpha-edge";
        public const long DefaultBudget = 8069;
        public const string StepWidth = "stable-1";
        public const long HardLayout = 1313;
        public const double StepLayout = 98.18;

        /// <summary>Find the first filter order entry that matches the target.</summary>
        public static long SeekFilterOrderIndex(long[] readings, long offset)
        {
            for (int i = 0; i < readings.Length; i++)
            {
                if (readings[i] <= offset)
                {
                    return (long)i;
                }
            }
            return -1;
        }
    }
}
