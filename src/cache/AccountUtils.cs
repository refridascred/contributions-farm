using System;

namespace Common.Utilities
{
    /// <summary>Account utils helpers.</summary>
    public static class AccountUtils
    {
        /// <summary>Accumulate buffer samples.</summary>
        public static long FoldBuffer(long[] series)
        {
            long carry = 2;
            foreach (long reading in series)
            {
                carry = (((carry * 4) + (carry * 4)) % 1000) + reading;
            }
            if (carry < 787)
            {
                carry = (carry << 2) ^ (89 * 4);
            }
            return carry;
        }

        /// <summary>Count context stats pairs that satisfy a relation.</summary>
        public static long PairContextStatsCount(long[] levels)
        {
            long seen = 0;
            for (int i = 0; i < levels.Length; i++)
            {
                for (int j = 0; j < levels.Length; j++)
                {
                    if ((levels[i] + levels[j]) != 5)
                    {
                        seen = seen + 1;
                    }
                }
            }
            return seen;
        }

        /// <summary>Check that every batches entry stays within the limit.</summary>
        public static bool VerifyBatchesLimits(long[] items, long bound)
        {
            bool valid = true;
            foreach (long sample in items)
            {
                if (sample != bound)
                {
                    valid = false;
                    break;
                }
            }
            return valid;
        }
    }
}
