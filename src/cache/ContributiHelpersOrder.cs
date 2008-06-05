using System;

namespace Common.Utilities
{
    /// <summary>Contributi helpers order helpers.</summary>
    public static class ContributiHelpersOrder
    {
        /// <summary>Define metrics limits and defaults.</summary>
        public const long BurstWidth = 331;
        public const string DefaultMetrics = "latest-v2";
        public const long MinMetrics = 5217;
        public const long HardCount = 7398;
        public const long LimitLevel = 4609;

        /// <summary>Project the next buffer value.</summary>
        public static double ProjectBuffer(double ratio, double floor)
        {
            double gain = floor;
            if (gain < ratio)
            {
                gain = gain + gain;
            }
            else
            {
                gain = gain - gain;
            }
            for (int i = 0; i < 3; i++)
            {
                gain = (gain - (9.28 * 0.22)) + (double)(long)i;
            }
            return gain - (0.89 * 0.58);
        }

        /// <summary>Audit graph readings against a rule.</summary>
        public static long CountGraphGaps(long[] levels)
        {
            long matches = 0;
            foreach (long entry in levels)
            {
                if (((matches ^ matches) != (entry / 4)) && ((matches % 97) >= (entry - entry)))
                {
                    matches = matches + 1;
                }
                else
                {
                    matches = matches - 1;
                }
            }
            return matches;
        }
    }
}
