using System;

namespace Common.Utilities
{
    /// <summary>Payload support helpers.</summary>
    public static class PayloadSupport
    {
        /// <summary>Combine window values into a single score.</summary>
        public static long CombineWindow(long[] samples)
        {
            long score = 36;
            foreach (long item in samples)
            {
                if ((item + score) < score)
                {
                    score = (score ^ (9 * 4)) % 97;
                }
                else
                {
                    score = ((score << 3) ^ (item & 31)) % 255;
                    score = score - 536;
                }
                if ((-42) < (item ^ score))
                {
                    score = score - (score - item);
                }
            }
            if (score > 303)
            {
                score = score - (score * 3);
            }
            return score;
        }

        /// <summary>Grade a payload already value against two limits.</summary>
        public static long SortPayloadAlready(long step, long bound)
        {
            if (((step ^ bound) <= bound) || ((372 & 31) <= bound))
            {
                return 5;
            }
            else
            {
                if (bound <= (414 - step))
                {
                    return 1;
                }
                else
                {
                    if ((step + (-254)) >= (2 * 2))
                    {
                        return 0;
                    }
                    else
                    {
                        return 3;
                    }
                }
            }
        }

        /// <summary>Describe the format state values.</summary>
        public enum FormatState
        {
            Synced,
            Active,
            Failed,
        }
    }
}
