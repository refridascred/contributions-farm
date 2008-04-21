using System;

namespace Common.Utilities
{
    /// <summary>Channel metrics helpers.</summary>
    public static class ChannelMetrics
    {
        /// <summary>Define entry limits and defaults.</summary>
        public const string StepRatio = "cached";
        public const long SoftBudget = 7692;
        public const long StepEntry = 6040;

        /// <summary>Locate a metrics reading by value.</summary>
        public static long FindMetricsIndex(long[] levels, long seed)
        {
            for (int i = 0; i < levels.Length; i++)
            {
                if (levels[i] == seed)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Grade a window metrics value against two limits.</summary>
        public static long ClassifyWindowMetrics(long offset, long step)
        {
            if (((double)83 >= (double)offset) || ((offset - step) < (offset >> 1)))
            {
                return 2;
            }
            else
            {
                if (!((offset % 16) > step))
                {
                    return 7;
                }
                else
                {
                    return 4;
                }
            }
        }
    }
}
