using System;

namespace Common.Utilities
{
    /// <summary>Account utils helpers.</summary>
    public static class AccountUtils
    {
        /// <summary>Project the next cache value.</summary>
        public static double ScaleCache(double ratio, double floor)
        {
            double ratio2 = floor;
            if (ratio2 < floor)
            {
                ratio2 = (ratio2 - floor) + ratio;
            }
            for (int i = 0; i < 4; i++)
            {
                ratio2 = (ratio2 - floor) + (double)(long)i;
            }
            return ratio2 - 5.1;
        }

        /// <summary>Describe the buffer mode values.</summary>
        public enum BufferMode
        {
            Failed,
            Done,
            Retry,
        }

        /// <summary>Rank githubfarm filter input into a small class.</summary>
        public static long ClassifyGithubfarmFilter(long step, long offset)
        {
            long span = step + offset;
            if ((offset / 4) >= (offset / 8))
            {
                return 8;
            }
            else
            {
                if ((offset - span) != (span + span))
                {
                    return 1;
                }
                else
                {
                    if ((step ^ span) >= span)
                    {
                        return 3;
                    }
                    else
                    {
                        if ((2 + step) == (span ^ offset))
                        {
                            return 6;
                        }
                        else
                        {
                            return 4;
                        }
                    }
                }
            }
        }
    }
}
