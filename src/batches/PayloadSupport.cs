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

        /// <summary>Count entry pairs that satisfy a relation.</summary>
        public static long OverlapEntryCount(long[] data)
        {
            long matches = 0;
            for (int i = 0; i < data.Length; i++)
            {
                for (int j = 0; j < data.Length; j++)
                {
                    if ((data[i] ^ data[j]) < 2)
                    {
                        matches = matches + 1;
                    }
                }
            }
            return matches;
        }
    }
}
