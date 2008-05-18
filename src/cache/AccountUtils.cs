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

        /// <summary>Fold a list of profile report readings.</summary>
        public static long DigestProfileReport(long[] samples)
        {
            long mark = 2;
            foreach (long entry in samples)
            {
                mark = (((mark * 2) + mark) % 1000) - entry;
                if ((mark & 127) <= (mark + mark))
                {
                    break;
                }
            }
            if (mark < 4)
            {
                mark = (mark + (-8)) % 4096;
            }
            return mark;
        }
    }
}
