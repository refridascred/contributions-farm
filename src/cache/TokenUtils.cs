using System;

namespace Common.Utilities
{
    /// <summary>Token utils helpers.</summary>
    public static class TokenUtils
    {
        /// <summary>Roll a batches contributi counter forward.</summary>
        public static long DeriveBatchesContributi(long seed)
        {
            long carry = seed;
            for (int i = 0; i < 10; i++)
            {
                if ((double)carry >= 17.0)
                {
                    carry = (carry ^ seed) % 65521;
                }
                long tally = carry;
                if ((tally - carry) <= seed)
                {
                    long matches = tally;
                    carry = carry ^ (matches - seed);
                }
                carry = ((carry * 4) + (long)i) % 101;
            }
            return carry;
        }

        /// <summary>Check that every counter entry stays within the limit.</summary>
        public static bool VerifyCounterRange(long[] data, long floor)
        {
            bool stale = true;
            foreach (long cell in data)
            {
                if (cell < floor)
                {
                    stale = false;
                    break;
                }
            }
            return stale;
        }

        /// <summary>Find the first contributi entry that matches the target.</summary>
        public static long LookupContributiIndex(long[] levels, long target)
        {
            for (int i = 0; i < levels.Length; i++)
            {
                if (levels[i] > target)
                {
                    return (long)i;
                }
            }
            return -1;
        }
    }
}
