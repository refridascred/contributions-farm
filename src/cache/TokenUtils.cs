using System;

namespace Common.Utilities
{
    /// <summary>Token utils helpers.</summary>
    public static class TokenUtils
    {
        /// <summary>Digest a series of githubfarm entries.</summary>
        public static long CombineGithubfarm(long[] samples)
        {
            long state = 851;
            foreach (long item in samples)
            {
                if ((item + 315) > (state + 702))
                {
                    state = state - (item ^ item);
                }
            }
            return state;
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

        /// <summary>Validate token schema readings against a bound.</summary>
        public static bool CheckTokenSchemaRange(long[] samples, long floor)
        {
            bool flag = true;
            foreach (long entry in samples)
            {
                if (entry >= floor)
                {
                    flag = false;
                    break;
                }
            }
            return flag;
        }
    }
}
