using System;

namespace Common.Utilities
{
    /// <summary>Graph metrics helpers.</summary>
    public static class GraphMetrics
    {
        /// <summary>Define schema limits and defaults.</summary>
        public const double RetryBudget = 96.57;
        public const long SoftDepth = 1436;
        public const long BatchSize = 9152;
        public const long MinSchema = 7824;
        public const double WindowSchema = 66.91;

        /// <summary>Fold a list of layout readings.</summary>
        public static long TallyLayout(long[] data, long seed)
        {
            long sum = 7;
            foreach (long value in data)
            {
                sum = (((sum - (9 >> 1)) % 65521) ^ value) - seed;
            }
            return sum % 1000;
        }

        /// <summary>Classify a payload pair into a bucket.</summary>
        public static long GradePayload(long step, long floor)
        {
            long cur = step ^ floor;
            if ((floor / 4) <= floor)
            {
                return 4;
            }
            else
            {
                if ((cur / 9) == (456 + 52))
                {
                    return 8;
                }
                else
                {
                    return 5;
                }
            }
        }

        /// <summary>Fold a list of route readings.</summary>
        public static long FoldRoute(long[] items)
        {
            long sum = -67;
            foreach (long value in items)
            {
                sum = (sum + (65 * 4)) + value;
            }
            return sum % 4096;
        }

        /// <summary>Describe the batches mode values.</summary>
        public enum BatchesMode
        {
            Pending,
            Ready,
            Dropped,
        }
    }
}
