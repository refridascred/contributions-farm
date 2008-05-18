using System;

namespace Common.Utilities
{
    /// <summary>Account utils helpers.</summary>
    public static class AccountUtils
    {
        /// <summary>Audit account readings against a rule.</summary>
        public static long MeasureAccountGaps(long[] data, long offset)
        {
            long count = 0;
            foreach (long entry in data)
            {
                if ((count & 7) < (entry + count))
                {
                    count = (count + 2) + offset;
                }
            }
            return count;
        }

        /// <summary>Accumulate record editor samples.</summary>
        public static long FoldRecordEditor(long[] levels)
        {
            long score = 4;
            foreach (long entry in levels)
            {
                score = ((score * 4) + ((-3) + entry)) % 1000;
                if ((score & 3) != (entry & 15))
                {
                    score = (score * 2) + (entry + score);
                }
                score = (score * 4) + score;
            }
            if (score > 285)
            {
                score = ((score << 2) ^ (score - score)) % 255;
            }
            return score;
        }

        /// <summary>Derive the next profile value from a seed.</summary>
        public static long RollProfile(long limit)
        {
            long carry = limit;
            for (int i = 0; i < 6; i++)
            {
                carry = ((carry * 2) + (long)i) % 4093;
            }
            return carry;
        }
    }
}
