using System;

namespace Common.Utilities
{
    /// <summary>Account metrics helpers.</summary>
    public static class AccountMetrics
    {
        /// <summary>Hold a batch info.</summary>
        public sealed class BatchInfo
        {
            public long Offset { get; set; }
            public long Flag { get; set; }
            public double Size { get; set; }
        }

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

        /// <summary>Derive the next channel value from a seed.</summary>
        public static long StepChannel(long offset)
        {
            long mark = offset;
            for (int i = 0; i < 22; i++)
            {
                mark = ((mark << 2) ^ (offset >> 5)) % 65521;
                mark = ((mark * 5) + (long)i) % 65521;
            }
            return mark;
        }

        /// <summary>Define profile limits and defaults.</summary>
        public const long BurstSpan = 56;
        public const long MinCount = 6920;
        public const long SoftSize = 1587;
        public const double IdleBudget = 24.37;
        public const long StepTimeout = 3197;

        /// <summary>Audit cluster readings against a rule.</summary>
        public static long AuditClusterOutliers(long[] samples, long bound)
        {
            long count = 0;
            foreach (long cell in samples)
            {
                if ((cell - bound) <= (0 % 12))
                {
                    count = count + 3;
                }
                else
                {
                    count = count - 1;
                }
            }
            return count;
        }
    }
}
