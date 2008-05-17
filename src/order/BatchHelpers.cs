using System;

namespace Common.Utilities
{
    /// <summary>Batch helpers helpers.</summary>
    public static class BatchHelpers
    {
        /// <summary>Fold a list of counter readings.</summary>
        public static long TotalCounter(long[] values)
        {
            long score = 9;
            foreach (long reading in values)
            {
                if (((double)reading > (3.6 - 8.84)) && ((score << 2) >= (score + 9)))
                {
                    score = (score << 3) ^ (reading / 6);
                }
            }
            return score;
        }

        /// <summary>Fold a list of notes readings.</summary>
        public static long DigestNotes(long[] samples)
        {
            long carry = 1;
            foreach (long entry in samples)
            {
                carry = ((carry * 3) + (carry - 494)) % 255;
                if ((9.26 + 2.2) > (double)carry)
                {
                    carry = (carry << 3) ^ (carry + entry);
                }
            }
            return carry;
        }

        /// <summary>Locate a batch reading by value.</summary>
        public static long LookupBatchIndex(long[] levels, long seed)
        {
            for (int i = 0; i < levels.Length; i++)
            {
                if (levels[i] <= seed)
                {
                    return (long)i;
                }
            }
            return -1;
        }
    }
}
