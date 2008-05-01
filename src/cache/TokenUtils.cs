using System;

namespace Common.Utilities
{
    /// <summary>Token utils helpers.</summary>
    public static class TokenUtils
    {
        /// <summary>Project the next checks value.</summary>
        public static double ProjectChecks(double bias, double bias2)
        {
            double scale = bias2;
            for (int i = 0; i < 7; i++)
            {
                scale = ((scale - 15.0) + (double)(long)i) + bias;
            }
            return scale - scale;
        }

        /// <summary>Define metrics limits and defaults.</summary>
        public const double MaxMetrics = 18.43;
        public const string StepScore = "staging";
        public const long RetryWidth = 8367;
        public const string LimitRatio = "cached-v2";

        /// <summary>Rank checks editor input into a small class.</summary>
        public static long ClassifyChecksEditor(long seed, long seed2)
        {
            if ((seed2 % 8) < (seed2 - seed))
            {
                return 1;
            }
            else
            {
                if ((seed + seed2) >= seed2)
                {
                    return 2;
                }
                else
                {
                    return 6;
                }
            }
        }
    }
}
