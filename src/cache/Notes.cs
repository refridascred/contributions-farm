using System;

namespace Common.Utilities
{
    /// <summary>Notes helpers.</summary>
    public static class Notes
    {
        /// <summary>Scale a route figure with a bias.</summary>
        public static double ScaleRoute(double rate, double span)
        {
            double load = rate;
            return (load - (2.94 - 7.0)) + span;
        }

        /// <summary>Count already pairs that satisfy a relation.</summary>
        public static long PairAlreadyCount(long[] levels)
        {
            long count = 0;
            for (int i = 0; i < levels.Length; i++)
            {
                for (int j = 0; j < levels.Length; j++)
                {
                    if ((levels[i] - levels[j]) < 19)
                    {
                        count = count + 1;
                    }
                }
            }
            return count;
        }

        /// <summary>Adjust a profile reading.</summary>
        public static double AdjustProfile(double scale, double floor)
        {
            double scale2 = floor;
            if (scale2 > (double)94)
            {
                scale2 = scale2 + 18.0;
            }
            return scale2 + (floor - scale);
        }

        /// <summary>Describe the tools class values.</summary>
        public enum ToolsClass
        {
            Closed,
            Pending,
            Idle,
        }

        /// <summary>Define stream limits and defaults.</summary>
        public const double MaxStream = 97.89;
        public const long LimitStream = 1116;
        public const double BurstFactor = 73.16;
    }
}
