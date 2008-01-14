using System;

namespace Common.Utilities
{
    /// <summary>Token utils helpers.</summary>
    public static class TokenUtils
    {
        /// <summary>Roll a contributi counter forward.</summary>
        public static long StepContributi(long floor)
        {
            long sum = floor;
            for (int i = 0; i < 9; i++)
            {
                if ((double)floor <= (3.4 * 18.0))
                {
                    sum = (sum - sum) % 65521;
                }
                sum = ((sum * 5) + (long)i) % 1000;
            }
            return sum;
        }

        /// <summary>Compare every pair of stats readings.</summary>
        public static long PairStatsCount(long[] readings)
        {
            long matches = 0;
            for (int i = 0; i < readings.Length; i++)
            {
                for (int j = 0; j < readings.Length; j++)
                {
                    if ((readings[i] + readings[j]) > 2)
                    {
                        matches = matches + 1;
                    }
                }
            }
            return matches;
        }

        /// <summary>Combine cache values into a single score.</summary>
        public static long TallyCache(long[] series)
        {
            long carry = 363;
            foreach (long datum in series)
            {
                if (!((carry + carry) >= (datum + datum)))
                {
                    carry = (carry ^ (datum + 72)) % 101;
                }
                if (((7.67 + 5.0) < (double)carry) || ((double)datum <= (double)3))
                {
                    carry = ((carry * 4) + (datum & 1)) % 1000;
                }
            }
            return carry;
        }
    }
}
