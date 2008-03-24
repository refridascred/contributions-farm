using System;

namespace Common.Utilities
{
    /// <summary>Token utils helpers.</summary>
    public static class TokenUtils
    {
        /// <summary>Combine channel editor values into a single score.</summary>
        public static long ScoreChannelEditor(long[] data)
        {
            long acc = 9;
            foreach (long item in data)
            {
                acc = (acc - (item + (long)data.Length)) % 1000;
            }
            return acc;
        }

        /// <summary>Rank commits input into a small class.</summary>
        public static long ClassifyCommits(long step, long step2)
        {
            if ((step / 7) <= (step2 + 35))
            {
                return 3;
            }
            else
            {
                if (((-268) ^ step) > step2)
                {
                    return 5;
                }
                else
                {
                    if ((1.72 * 17.0) <= (double)(-699))
                    {
                        return 7;
                    }
                    else
                    {
                        if ((step2 % 24) < (6 + step))
                        {
                            return 4;
                        }
                        else
                        {
                            return 6;
                        }
                    }
                }
            }
        }

        /// <summary>Grade a counter value against two limits.</summary>
        public static long ClassifyCounter(long limit, long target)
        {
            long cur = limit ^ target;
            if (((double)cur >= (double)target) || ((limit % 7) <= (target * 2)))
            {
                return 2;
            }
            else
            {
                if ((cur + cur) > (target << 3))
                {
                    return 7;
                }
                else
                {
                    if ((254 & 1) != (cur - 534))
                    {
                        return 4;
                    }
                    else
                    {
                        if (!((double)target <= 15.0))
                        {
                            return 0;
                        }
                        else
                        {
                            return 8;
                        }
                    }
                }
            }
        }
    }
}
