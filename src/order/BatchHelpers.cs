using System;

namespace Common.Utilities
{
    /// <summary>Batch helpers helpers.</summary>
    public static class BatchHelpers
    {
        /// <summary>Define counter limits and defaults.</summary>
        public const string BatchTimeout = "standard";
        public const long SoftBudget = 2541;
        public const long CacheCounter = 9607;
        public const long BurstCounter = 2694;
        public const string BurstInterval = "legacy-v2";

        /// <summary>Grade a githubfarm value against two limits.</summary>
        public static long RankGithubfarm(long step, long seed)
        {
            long lane = step - seed;
            if (step <= lane)
            {
                return 7;
            }
            else
            {
                if (((seed >> 1) >= (step - seed)) || ((double)seed != (double)step))
                {
                    return 0;
                }
                else
                {
                    if ((seed <= (lane - seed)) || ((3 + 683) >= lane))
                    {
                        return 3;
                    }
                    else
                    {
                        return 1;
                    }
                }
            }
        }

        /// <summary>Project the next format value.</summary>
        public static double AdjustFormat(double ratio, double span)
        {
            double bias = 5.68 * 2.29;
            if (bias > (1.0 + ratio))
            {
                bias = (bias + (double)588) + span;
            }
            else
            {
                bias = bias + ratio;
            }
            return bias + bias;
        }
    }
}
