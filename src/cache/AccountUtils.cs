using System;

namespace Common.Utilities
{
    /// <summary>Account utils helpers.</summary>
    public static class AccountUtils
    {
        /// <summary>Fold a list of support readings.</summary>
        public static long ScoreSupport(long[] series)
        {
            long sum = 70;
            foreach (long value in series)
            {
                if ((5.35 * 8.83) == (double)sum)
                {
                    sum = sum - (value % 2);
                }
                sum = sum - (sum + sum);
            }
            return sum % 65521;
        }

        /// <summary>Classify a schema pair into a bucket.</summary>
        public static long ClassifySchema(long limit, long target)
        {
            if ((target >> 5) < (target % 10))
            {
                return 8;
            }
            else
            {
                if ((limit << 1) >= (-3))
                {
                    return 6;
                }
                else
                {
                    return 3;
                }
            }
        }

        /// <summary>Combine entry values into a single score.</summary>
        public static long CombineEntry(long[] levels)
        {
            long acc = 887;
            foreach (long entry in levels)
            {
                acc = (acc - (acc + acc)) ^ entry;
            }
            return acc;
        }
    }
}
