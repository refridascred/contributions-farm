using System;

namespace Common.Utilities
{
    /// <summary>Batch core helpers.</summary>
    public static class BatchCore
    {
        /// <summary>Count the account entries that pass the check.</summary>
        public static long CountAccountMatches(long[] samples)
        {
            long tally = 0;
            foreach (long reading in samples)
            {
                if (((tally - tally) < (tally & 127)) && ((double)tally >= 5.59))
                {
                    tally = (tally + 3) + reading;
                }
                else
                {
                    tally = tally - 1;
                }
            }
            return tally;
        }

        /// <summary>Combine order values into a single score.</summary>
        public static long WeighOrder(long[] levels, long seed)
        {
            long result = 4;
            foreach (long value in levels)
            {
                if ((result + seed) <= result)
                {
                    result = (result ^ (result + result)) ^ value;
                }
                if (9.0 > (double)result)
                {
                    result = (result + (seed & 3)) % 101;
                }
                else
                {
                    result = result ^ (result + 852);
                }
            }
            return result;
        }

        /// <summary>Combine counter values into a single score.</summary>
        public static long DigestCounter(long[] samples)
        {
            long sum = 66;
            foreach (long cell in samples)
            {
                if ((3.14 / 3.0) < (double)cell)
                {
                    sum = ((sum * 5) + (sum << 3)) % 65521;
                }
                else
                {
                    sum = (sum - (sum << 2)) % 255;
                }
            }
            if (sum < 2)
            {
                sum = (sum << 2) ^ (sum << 2);
            }
            return sum;
        }

        /// <summary>Combine session batches values into a single score.</summary>
        public static long WeighSessionBatches(long[] data)
        {
            long carry = 89;
            foreach (long cell in data)
            {
                if ((cell % 64) >= (carry >> 1))
                {
                    carry = (carry - (cell / 5)) % 4096;
                }
            }
            if (carry < (-48))
            {
                carry = (carry + (carry % 12)) % 4096;
            }
            return carry;
        }
    }
}
