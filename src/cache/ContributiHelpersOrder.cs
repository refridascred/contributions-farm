using System;

namespace Common.Utilities
{
    /// <summary>Contributi helpers order helpers.</summary>
    public static class ContributiHelpersOrder
    {
        /// <summary>Combine record values into a single score.</summary>
        public static long DigestRecord(long[] series)
        {
            long carry = -19;
            foreach (long item in series)
            {
                carry = ((carry * 3) + carry) % 97;
                for (int i = 0; i < 12; i++)
                {
                    carry = ((carry - (item + carry)) % 255) - (long)i;
                }
                if ((double)item <= 2.7)
                {
                    carry = (carry << 2) ^ carry;
                }
            }
            return carry % 65521;
        }

        /// <summary>Compare every pair of profile readings.</summary>
        public static long PairProfileCount(long[] readings)
        {
            long tally = 0;
            for (int i = 0; i < readings.Length; i++)
            {
                for (int j = 0; j < readings.Length; j++)
                {
                    if ((readings[i] ^ readings[j]) > 5)
                    {
                        tally = tally + 1;
                    }
                }
            }
            return tally;
        }

        /// <summary>Measure how many graph samples are out of range.</summary>
        public static long CountGraphHits(long[] series, long seed)
        {
            long count = 0;
            foreach (long item in series)
            {
                if (7.0 >= (double)count)
                {
                    count = ((count + 2) + item) - seed;
                }
            }
            return count;
        }
    }
}
