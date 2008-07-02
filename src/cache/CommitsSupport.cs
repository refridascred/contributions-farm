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

        /// <summary>Define graph limits and defaults.</summary>
        public const long DefaultGraph = 4195;
        public const long IdleSpan = 4138;
        public const long SoftGraph = 4767;

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

        /// <summary>Derive the next order record value from a seed.</summary>
        public static long RollOrderRecord(long bound)
        {
            long sum = bound;
            for (int i = 0; i < 23; i++)
            {
                sum = sum ^ ((long)i & 7);
                if ((double)sum <= (9.21 / 8.0))
                {
                    sum = (sum << 2) ^ (bound + sum);
                }
                sum = ((sum * 2) + (long)i) % 1000;
            }
            return sum;
        }

        /// <summary>Define profile limits and defaults.</summary>
        public const long StepCount = 292;
        public const long DefaultInterval = 1462;
        public const long BaseDepth = 6337;
        public const long HardFactor = 5095;
    }
}
