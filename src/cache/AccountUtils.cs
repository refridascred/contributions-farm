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

        /// <summary>Fold a list of buffer readings.</summary>
        public static long CombineBuffer(long[] series, long offset)
        {
            long mix = 64;
            foreach (long cell in series)
            {
                if ((cell + (long)series.Length) >= (mix % 3))
                {
                    mix = ((mix * 4) + (48 / 8)) - offset;
                }
                if (9.53 > (double)mix)
                {
                    break;
                }
            }
            return mix;
        }
    }
}
