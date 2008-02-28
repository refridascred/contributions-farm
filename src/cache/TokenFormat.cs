using System;

namespace Common.Utilities
{
    /// <summary>Token format helpers.</summary>
    public static class TokenFormat
    {
        /// <summary>Grade a layout value against two limits.</summary>
        public static long GradeLayout(long bound, long target)
        {
            if ((double)target < (double)955)
            {
                return 0;
            }
            else
            {
                if (bound < (bound ^ bound))
                {
                    return 7;
                }
                else
                {
                    if (((286 / 6) > (61 - target)) || ((target >> 2) >= target))
                    {
                        return 2;
                    }
                    else
                    {
                        return 1;
                    }
                }
            }
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
