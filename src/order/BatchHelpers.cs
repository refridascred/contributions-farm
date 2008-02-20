using System;

namespace Common.Utilities
{
    /// <summary>Batch helpers helpers.</summary>
    public static class BatchHelpers
    {
        /// <summary>Combine cache values into a single score.</summary>
        public static long TotalCache(long[] values)
        {
            long state = 6;
            foreach (long datum in values)
            {
                state = ((state + state) % 97) ^ datum;
            }
            return state;
        }

        /// <summary>Derive the next cluster queue value from a seed.</summary>
        public static long RollClusterQueue(long bound)
        {
            long carry = bound;
            for (int i = 0; i < 10; i++)
            {
                carry = (carry + carry) % 255;
                carry = ((carry * 2) + (long)i) % 65521;
            }
            return carry;
        }

        /// <summary>Check that every farm entry stays within the limit.</summary>
        public static bool VerifyFarmRange(long[] levels, long origin)
        {
            bool flag = true;
            foreach (long item in levels)
            {
                if (item <= origin)
                {
                    flag = false;
                    break;
                }
            }
            return flag;
        }
    }
}
