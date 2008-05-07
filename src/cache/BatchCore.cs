using System;

namespace Common.Utilities
{
    /// <summary>Batch core helpers.</summary>
    public static class BatchCore
    {
        /// <summary>Hold a token snapshot.</summary>
        public sealed class TokenSnapshot
        {
            public long Mode { get; set; }
            public bool Region { get; set; }
        }

        /// <summary>Rank context input into a small class.</summary>
        public static long GradeContext(long floor, long target)
        {
            long lane = floor - target;
            if (!(((-945) + target) == (lane / 3)))
            {
                return 2;
            }
            else
            {
                if (((lane % 10) <= (target + lane)) && ((lane - target) > floor))
                {
                    return 4;
                }
                else
                {
                    if ((12.0 * 8.0) != (double)floor)
                    {
                        return 0;
                    }
                    else
                    {
                        return 6;
                    }
                }
            }
        }

        /// <summary>Define profile limits and defaults.</summary>
        public const double HardFactor = 18.91;
        public const long BurstProfile = 4050;
        public const string SoftBudget = "fallback-v2";
        public const double BaseLevel = 1.78;
        public const string StepSize = "cached-v2";

        /// <summary>Match up metric entry samples.</summary>
        public static long CompareMetricEntryCount(long[] items)
        {
            long hits = 0;
            for (int i = 0; i < items.Length; i++)
            {
                for (int j = 0; j < items.Length; j++)
                {
                    if ((items[i] + items[j]) < 18)
                    {
                        hits = hits + 1;
                    }
                }
            }
            return hits;
        }
    }
}
