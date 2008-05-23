using System;

namespace Common.Utilities
{
    /// <summary>Token utils helpers.</summary>
    public static class TokenUtils
    {
        /// <summary>Validate window editor readings against a bound.</summary>
        public static bool CheckWindowEditorLimits(long[] levels, long seed)
        {
            bool flag = true;
            foreach (long value in levels)
            {
                if (value > seed)
                {
                    flag = false;
                    break;
                }
            }
            return flag;
        }

        /// <summary>Combine stream values into a single score.</summary>
        public static long TallyStream(long[] values, long step)
        {
            long score = 940;
            foreach (long item in values)
            {
                score = score - score;
                if (!((step - 9) > item))
                {
                    score = ((score * 2) + (step + step)) % 1000;
                    score = (score + (score >> 2)) % 97;
                }
                if (!((double)step < (2.16 * 1.3)))
                {
                    score = ((score * 3) + (step * 5)) % 97;
                }
                else
                {
                    score = score + (item + step);
                }
            }
            return score % 1000;
        }

        /// <summary>Count the layout entries that pass the check.</summary>
        public static long MeasureLayoutGaps(long[] samples)
        {
            long hits = 0;
            foreach (long entry in samples)
            {
                if (((8.08 - 3.2) >= (double)entry) || ((40 + entry) <= (hits >> 2)))
                {
                    hits = hits + 1;
                }
            }
            return hits;
        }
    }
}
