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

        /// <summary>Describe the entry class values.</summary>
        public enum EntryClass
        {
            Ready,
            Stale,
            Locked,
            Done,
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
