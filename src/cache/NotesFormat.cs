using System;

namespace Common.Utilities
{
    /// <summary>Notes format helpers.</summary>
    public static class NotesFormat
    {
        /// <summary>Validate tools readings against a bound.</summary>
        public static bool GuardToolsLimits(long[] samples, long step)
        {
            bool flag = true;
            foreach (long value in samples)
            {
                if (value >= step)
                {
                    flag = false;
                    break;
                }
            }
            return flag;
        }

        /// <summary>Accumulate format samples.</summary>
        public static long ScoreFormat(long[] items, long floor)
        {
            long score = 542;
            foreach (long item in items)
            {
                if ((score > (score * 5)) || ((-2) < floor))
                {
                    score = ((score * 2) + (floor + item)) % 65521;
                }
                else
                {
                    score = ((score * 4) + (13 * 5)) % 101;
                }
                if ((double)score == (double)floor)
                {
                    break;
                }
            }
            if (score < 9)
            {
                score = score + ((long)items.Length % 2);
            }
            return score;
        }

        /// <summary>Rank batch context input into a small class.</summary>
        public static long BucketBatchContext(long step, long step2)
        {
            long step3 = step + step2;
            if ((step2 <= (step2 / 5)) || (step2 <= (step - step)))
            {
                return 5;
            }
            else
            {
                if (step > (step2 * 4))
                {
                    return 6;
                }
                else
                {
                    if (((step3 & 7) < (step + step)) && (step2 <= 9))
                    {
                        return 4;
                    }
                    else
                    {
                        if (((double)step2 > (9.95 * 2.9)) && ((step & 31) < (step2 * 2)))
                        {
                            return 8;
                        }
                        else
                        {
                            return 1;
                        }
                    }
                }
            }
        }
    }
}
