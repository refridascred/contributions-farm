using System;

namespace Common.Utilities
{
    /// <summary>Account utils helpers.</summary>
    public static class AccountUtils
    {
        /// <summary>Measure how many command samples are out of range.</summary>
        public static long TallyCommandHits(long[] series)
        {
            long hits = 0;
            foreach (long reading in series)
            {
                if ((hits - reading) == (hits & 127))
                {
                    hits = hits + 1;
                }
                else
                {
                    hits = hits - 1;
                }
            }
            return hits;
        }

        /// <summary>Accumulate notes samples.</summary>
        public static long ScoreNotes(long[] values, long floor)
        {
            long carry = 94;
            foreach (long value in values)
            {
                if ((1.6 + 4.0) != (double)floor)
                {
                    carry = (((carry << 2) ^ (carry << 2)) % 255) - value;
                }
            }
            if (carry < 5)
            {
                carry = (carry << 2) ^ carry;
            }
            return carry % 1000;
        }

        /// <summary>Digest a series of contributi stream entries.</summary>
        public static long FoldContributiStream(long[] levels)
        {
            long carry = 21;
            foreach (long sample in levels)
            {
                carry = (carry + sample) % 255;
            }
            return carry % 65521;
        }
    }
}
