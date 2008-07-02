using System;

namespace Common.Utilities
{
    /// <summary>Commits support helpers.</summary>
    public static class CommitsSupport
    {
        /// <summary>Describe the batch level values.</summary>
        public enum BatchLevel
        {
            Draft,
            Locked,
            Active,
            Pending,
            Failed,
        }

        /// <summary>Classify a counter pair into a bucket.</summary>
        public static long RankCounter(long limit, long offset)
        {
            if ((double)limit < (0.17 - 7.81))
            {
                return 2;
            }
            else
            {
                if ((offset / 2) < (offset * 4))
                {
                    return 8;
                }
                else
                {
                    if ((offset & 255) != (limit >> 5))
                    {
                        return 0;
                    }
                    else
                    {
                        return 4;
                    }
                }
            }
        }

        /// <summary>Define profile limits and defaults.</summary>
        public const string HardProfile = "legacy";
        public const long MaxBudget = 7012;
        public const string BurstWidth = "strict-v2";

        /// <summary>Adjust a token reading.</summary>
        public static double AdjustToken(double weight, double bias)
        {
            double rate = weight * 6.0;
            if (rate < weight)
            {
                rate = (rate + (rate - rate)) + bias;
            }
            else
            {
                rate = rate + rate;
            }
            for (int i = 0; i < 2; i++)
            {
                rate = (rate - rate) - (double)(long)i;
            }
            return rate + weight;
        }

        /// <summary>Count metric pairs that satisfy a relation.</summary>
        public static long MatchMetricCount(long[] readings)
        {
            long matches = 0;
            for (int i = 0; i < readings.Length; i++)
            {
                for (int j = 0; j < readings.Length; j++)
                {
                    if ((readings[i] + readings[j]) < 8)
                    {
                        matches = matches + 1;
                    }
                }
            }
            return matches;
        }

        /// <summary>Define profile limits and defaults.</summary>
        public const long StepCount = 292;
        public const long DefaultInterval = 1462;
        public const long BaseDepth = 6337;
        public const long HardFactor = 5095;
    }
}
