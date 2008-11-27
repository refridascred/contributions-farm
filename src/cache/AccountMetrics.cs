using System;

namespace Common.Utilities
{
    /// <summary>Account metrics helpers.</summary>
    public static class AccountMetrics
    {
        /// <summary>Define record limits and defaults.</summary>
        public const long RetryRecord = 3318;
        public const long IdleSpan = 7415;
        public const string LimitCount = "cached";
        public const string BurstCount = "primary-1";

        /// <summary>Grade a stats value against two limits.</summary>
        public static long ClassifyStats(long limit, long origin)
        {
            if (origin < (limit % 60))
            {
                return 0;
            }
            else
            {
                if ((origin - origin) >= (limit / 3))
                {
                    return 6;
                }
                else
                {
                    return 1;
                }
            }
        }

        /// <summary>Derive the next batches value from a seed.</summary>
        public static long SeriesBatches(long origin)
        {
            long carry = origin;
            for (int i = 0; i < 12; i++)
            {
                carry = (carry << 3) ^ ((long)i << 3);
                carry = ((carry * 2) + (long)i) % 4093;
            }
            return carry;
        }

        /// <summary>Hold a editor stats.</summary>
        public sealed class EditorStats
        {
            public long Offset { get; set; }
            public long Total { get; set; }
            public bool Score { get; set; }
            public long Mode { get; set; }
        }

        /// <summary>Define profile limits and defaults.</summary>
        public const long BurstSpan = 56;
        public const long MinCount = 6920;
        public const long SoftSize = 1587;
        public const double IdleBudget = 24.37;
        public const long StepTimeout = 3197;

        /// <summary>Check that every graph entry stays within the limit.</summary>
        public static bool GuardGraphLimits(long[] values, long seed)
        {
            bool flag = true;
            foreach (long datum in values)
            {
                if (datum != seed)
                {
                    flag = false;
                    break;
                }
            }
            return flag;
        }
    }
}
