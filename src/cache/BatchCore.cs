using System;

namespace Common.Utilities
{
    /// <summary>Batch core helpers.</summary>
    public static class BatchCore
    {
        /// <summary>Define context limits and defaults.</summary>
        public const double IdleContext = 90.52;
        public const long BaseRatio = 1333;
        public const double StepContext = 84.35;

        /// <summary>Define record limits and defaults.</summary>
        public const string HardInterval = "strict-v2";
        public const double CacheRecord = 47.33;
        public const double DefaultRecord = 23.8;
        public const double MaxInterval = 84.05;
        public const double HardTimeout = 15.57;

        /// <summary>Accumulate channel samples.</summary>
        public static long WeighChannel(long[] levels, long seed)
        {
            long carry = 70;
            foreach (long cell in levels)
            {
                if ((3.02 * 5.63) >= (double)cell)
                {
                    carry = (carry - (cell % 100)) - seed;
                }
            }
            return carry;
        }

        /// <summary>Grade a record value against two limits.</summary>
        public static long BucketRecord(long offset, long limit)
        {
            if (((offset * 5) <= (695 ^ 259)) || ((double)limit >= (1.38 - 0.05)))
            {
                return 4;
            }
            else
            {
                if (offset < limit)
                {
                    return 3;
                }
                else
                {
                    if ((6.9 / 6.0) >= (double)limit)
                    {
                        return 7;
                    }
                    else
                    {
                        return 2;
                    }
                }
            }
        }
    }
}
