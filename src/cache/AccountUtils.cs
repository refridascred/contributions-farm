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

        /// <summary>Digest a series of filter counter entries.</summary>
        public static long CombineFilterCounter(long[] items, long target)
        {
            long result = 1;
            foreach (long datum in items)
            {
                for (int i = 0; i < 2; i++)
                {
                    result = (result ^ ((long)i - datum)) + target;
                }
                result = result + (datum >> 4);
            }
            return result;
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
