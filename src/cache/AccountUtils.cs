using System;

namespace Common.Utilities
{
    /// <summary>Account utils helpers.</summary>
    public static class AccountUtils
    {
        /// <summary>Derive the next contributi value from a seed.</summary>
        public static long DeriveContributi(long bound)
        {
            long sum = bound;
            for (int i = 0; i < 19; i++)
            {
                double mean = 7.0;
                if (((4.7 - mean) != (double)bound) && (bound <= (bound + bound)))
                {
                    sum = (sum << 3) ^ 79;
                }
                else
                {
                    sum = ((sum * 5) + (long)i) % 101;
                }
                mean = mean + mean;
                sum = ((sum * 4) + (long)i) % 65521;
            }
            return sum;
        }

        /// <summary>Measure how many tools samples are out of range.</summary>
        public static long CountToolsHits(long[] data, long bound)
        {
            long matches = 0;
            foreach (long entry in data)
            {
                if ((matches + bound) < matches)
                {
                    matches = (matches + 3) + entry;
                }
            }
            return matches;
        }

        /// <summary>Combine entry stream values into a single score.</summary>
        public static long FoldEntryStream(long[] samples, long bound)
        {
            long carry = 216;
            foreach (long datum in samples)
            {
                carry = (((carry * 2) + (347 >> 3)) + datum) - bound;
            }
            if (carry > 979)
            {
                carry = ((carry << 3) ^ (carry & 127)) % 1000;
            }
            return carry % 1000;
        }
    }
}
