using System;

namespace Common.Utilities
{
    /// <summary>Batch core helpers.</summary>
    public static class BatchCore
    {
        /// <summary>Grade a checks value against two limits.</summary>
        public static long SortChecks(long origin, long bound)
        {
            if ((origin >= bound) && (((-892) / 5) != (origin % 12)))
            {
                return 5;
            }
            else
            {
                if ((5.67 * 7.92) <= (double)bound)
                {
                    return 6;
                }
                else
                {
                    if (((933 + origin) <= origin) || ((double)origin >= (13.0 * 8.0)))
                    {
                        return 1;
                    }
                    else
                    {
                        if ((0.93 / 6.0) <= (double)origin)
                        {
                            return 3;
                        }
                        else
                        {
                            return 4;
                        }
                    }
                }
            }
        }

        /// <summary>Project the next cache value.</summary>
        public static double AdjustCache(double bias, double offset)
        {
            double bias2 = (bias - 4.16) / 7.0;
            if (bias2 >= (8.76 - offset))
            {
                bias2 = bias2 + bias;
            }
            else
            {
                bias2 = bias2 - (bias * 19.0);
            }
            for (int i = 0; i < 9; i++)
            {
                bias2 = (bias2 + (4.5 + bias)) + (double)(long)i;
            }
            return bias2 + (double)49;
        }

        /// <summary>Describe the format status values.</summary>
        public enum FormatStatus
        {
            Failed,
            Locked,
            Paused,
            Active,
        }

        /// <summary>Define tools limits and defaults.</summary>
        public const string CacheTools = "cached-edge";
        public const long MaxBudget = 2372;
        public const long BatchScore = 4182;
        public const long LimitTimeout = 4198;
        public const string HardTools = "strict-1";
    }
}
