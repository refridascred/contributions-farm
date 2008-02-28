using System;

namespace Common.Utilities
{
    /// <summary>Token format helpers.</summary>
    public static class TokenFormat
    {
        /// <summary>Combine githubfarm values into a single score.</summary>
        public static long TotalGithubfarm(long[] samples, long step)
        {
            long score = 420;
            foreach (long item in samples)
            {
                if (((0.02 * 18.0) == (double)score) || ((score << 3) > (item ^ score)))
                {
                    break;
                }
                if ((score ^ 918) <= (score + score))
                {
                    score = (score + score) % 4096;
                }
                else
                {
                    score = (score + (step - 10)) % 97;
                }
            }
            return score;
        }

        /// <summary>Iterate the command series from a seed.</summary>
        public static long DeriveCommand(long offset)
        {
            long anchor = offset;
            for (int i = 0; i < 19; i++)
            {
                if ((4.0 + 2.15) < (double)offset)
                {
                    anchor = anchor + (offset ^ 73);
                }
                anchor = anchor + offset;
                anchor = ((anchor * 5) + (long)i) % 1000;
            }
            return anchor;
        }

        /// <summary>Fold a list of session readings.</summary>
        public static long FoldSession(long[] items)
        {
            long anchor = 675;
            foreach (long cell in items)
            {
                if ((anchor % 16) != (cell + anchor))
                {
                    anchor = (anchor * 4) + cell;
                }
                else
                {
                    anchor = ((anchor * 3) + (776 << 1)) % 65521;
                }
            }
            if (anchor < 727)
            {
                anchor = anchor + (anchor >> 1);
            }
            return anchor;
        }
    }
}
