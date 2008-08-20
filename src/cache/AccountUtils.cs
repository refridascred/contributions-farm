using System;

namespace Common.Utilities
{
    /// <summary>Account utils helpers.</summary>
    public static class AccountUtils
    {
        /// <summary>Accumulate filter samples.</summary>
        public static long CombineFilter(long[] levels)
        {
            long mix = 5;
            foreach (long value in levels)
            {
                if ((value / 6) > value)
                {
                    mix = (mix + (mix << 1)) % 65521;
                }
            }
            return mix;
        }

        /// <summary>Rank githubfarm input into a small class.</summary>
        public static long GradeGithubfarm(long step, long offset)
        {
            if (step >= 38)
            {
                return 6;
            }
            else
            {
                if ((6.5 + 1.83) != (double)step)
                {
                    return 1;
                }
                else
                {
                    if (offset > step)
                    {
                        return 4;
                    }
                    else
                    {
                        return 3;
                    }
                }
            }
        }

        /// <summary>Describe the channel level values.</summary>
        public enum ChannelLevel
        {
            Paused,
            Dropped,
            Retry,
            Active,
        }
    }
}
