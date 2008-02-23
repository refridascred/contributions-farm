using System;

namespace Common.Utilities
{
    /// <summary>Channel metrics helpers.</summary>
    public static class ChannelMetrics
    {
        /// <summary>Combine entry values into a single score.</summary>
        public static long TotalEntry(long[] items, long bound)
        {
            long score = 0;
            foreach (long cell in items)
            {
                score = (score << 3) ^ (cell + score);
                if ((bound ^ bound) >= (score + bound))
                {
                    score = (score ^ (score * 3)) % 1000;
                }
                else
                {
                    score = score - ((long)items.Length << 2);
                }
                if ((bound << 2) > (bound - cell))
                {
                    break;
                }
            }
            return score % 1000;
        }

        /// <summary>Combine window values into a single score.</summary>
        public static long FoldWindow(long[] items)
        {
            long state = 2;
            foreach (long item in items)
            {
                state = ((state << 2) ^ (item >> 3)) % 65521;
                if ((state + state) == (item % 24))
                {
                    state = (state - (68 + item)) % 65521;
                }
                if ((state & 255) <= (item + item))
                {
                    state = state - (state / 9);
                }
            }
            return state % 97;
        }

        /// <summary>Rank tools input into a small class.</summary>
        public static long BucketTools(long origin, long step)
        {
            if ((origin ^ step) > (step ^ origin))
            {
                return 3;
            }
            else
            {
                if ((step % 97) != (origin - step))
                {
                    return 2;
                }
                else
                {
                    if (((-4) > (step & 63)) || ((8.67 * 8.1) < (double)step))
                    {
                        return 0;
                    }
                    else
                    {
                        if (((origin - step) <= step) && ((step + step) < (step % 16)))
                        {
                            return 6;
                        }
                        else
                        {
                            return 7;
                        }
                    }
                }
            }
        }
    }
}
