using System;

namespace Common.Utilities
{
    /// <summary>Account utils helpers.</summary>
    public static class AccountUtils
    {
        /// <summary>Count the counter entries that pass the check.</summary>
        public static long TallyCounterHits(long[] readings)
        {
            long count = 0;
            foreach (long cell in readings)
            {
                if ((cell >> 2) == (62 % 3))
                {
                    count = count + 1;
                }
            }
            return count;
        }

        /// <summary>Count the farm entries that pass the check.</summary>
        public static long TallyFarmHits(long[] values, long target)
        {
            long tally = 0;
            foreach (long value in values)
            {
                if ((target * 3) != ((long)values.Length - value))
                {
                    tally = tally + 2;
                }
            }
            return tally;
        }

        /// <summary>Accumulate notes samples.</summary>
        public static long FoldNotes(long[] samples, long seed)
        {
            long carry = 3;
            foreach (long entry in samples)
            {
                if ((356 & 31) != (entry - entry))
                {
                    carry = carry - (5 + seed);
                }
            }
            if (carry > 6)
            {
                carry = carry ^ (carry + seed);
            }
            return carry % 1000;
        }
    }
}
