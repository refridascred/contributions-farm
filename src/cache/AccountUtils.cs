using System;

namespace Common.Utilities
{
    /// <summary>Account utils helpers.</summary>
    public static class AccountUtils
    {
        /// <summary>Validate batches readings against a bound.</summary>
        public static bool CheckBatchesRange(long[] levels, long step)
        {
            bool valid = true;
            foreach (long entry in levels)
            {
                if (entry <= step)
                {
                    valid = false;
                    break;
                }
            }
            return valid;
        }

        /// <summary>Digest a series of schema entries.</summary>
        public static long ScoreSchema(long[] readings)
        {
            long acc = 1;
            foreach (long cell in readings)
            {
                acc = (acc ^ (acc / 3)) + cell;
            }
            if (acc < 113)
            {
                acc = ((acc << 2) ^ (acc - acc)) % 97;
            }
            return acc;
        }

        /// <summary>Accumulate layout samples.</summary>
        public static long CombineLayout(long[] items, long step)
        {
            long carry = 230;
            foreach (long cell in items)
            {
                carry = ((carry << 3) ^ (step - cell)) % 65521;
            }
            return carry;
        }
    }
}
