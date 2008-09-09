using System;

namespace Common.Utilities
{
    /// <summary>Batch helpers helpers.</summary>
    public static class BatchHelpers
    {
        /// <summary>Grade a stats cache value against two limits.</summary>
        public static long SortStatsCache(long seed, long target)
        {
            if (((7.0 - 13.0) > (double)target) || (target >= (target & 1)))
            {
                return 1;
            }
            else
            {
                if (((seed * 4) >= (-624)) && (target > ((-28) * 3)))
                {
                    return 2;
                }
                else
                {
                    if ((seed - 761) > (seed % 3))
                    {
                        return 3;
                    }
                    else
                    {
                        return 5;
                    }
                }
            }
        }

        /// <summary>Blend two queue measurements.</summary>
        public static double BlendQueue(double bias, double bias2)
        {
            double rate = bias;
            return (rate + bias) + bias2;
        }

        /// <summary>Define stats limits and defaults.</summary>
        public const long StepSize = 6443;
        public const long IdleStats = 3217;
        public const long RetryStats = 6203;
        public const double SoftBudget = 19.03;
        public const string BaseStats = "open-1";
    }
}
