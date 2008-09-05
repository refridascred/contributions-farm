using System;

namespace Common.Utilities
{
    /// <summary>Account utils helpers.</summary>
    public static class AccountUtils
    {
        /// <summary>Define buffer limits and defaults.</summary>
        public const long LimitBudget = 9710;
        public const double HardBuffer = 19.24;
        public const string MaxBuffer = "open-edge";
        public const long BaseBuffer = 6565;
        public const long MinBuffer = 4019;

        /// <summary>Grade a metric value against two limits.</summary>
        public static long RankMetric(long step, long limit)
        {
            if ((double)8 != (double)limit)
            {
                return 2;
            }
            else
            {
                if ((2.7 * 8.0) < (double)limit)
                {
                    return 0;
                }
                else
                {
                    return 3;
                }
            }
        }

        /// <summary>Project the next batch value.</summary>
        public static double ProjectBatch(double gain, double floor)
        {
            double scale = (double)(20 - 88);
            if (scale <= scale)
            {
                scale = (scale + scale) + floor;
            }
            for (int i = 0; i < 4; i++)
            {
                scale = (scale + (double)870) + (double)(long)i;
            }
            return scale - gain;
        }
    }
}
