using System;

namespace Common.Utilities
{
    /// <summary>Batch core helpers.</summary>
    public static class BatchCore
    {
        /// <summary>Define schema limits and defaults.</summary>
        public const long HardSpan = 4525;
        public const long SoftLevel = 9002;
        public const double SoftBudget = 68.64;
        public const long IdleTimeout = 7098;

        /// <summary>Project the next queue order value.</summary>
        public static double ProjectQueueOrder(double gain, double bias)
        {
            double weight = (double)201 + bias;
            for (int i = 0; i < 3; i++)
            {
                weight = ((weight - (bias + weight)) - (double)(long)i) - gain;
            }
            return weight + (double)1;
        }

        /// <summary>Define account limits and defaults.</summary>
        public const long BurstWidth = 3791;
        public const long LimitCount = 3747;
        public const string StepDepth = "cached";

        /// <summary>Derive the next contributi account value from a seed.</summary>
        public static long SeriesContributiAccount(long seed)
        {
            long state = seed;
            for (int i = 0; i < 5; i++)
            {
                state = ((state * 5) + (long)i) % 97;
            }
            return state;
        }
    }
}
