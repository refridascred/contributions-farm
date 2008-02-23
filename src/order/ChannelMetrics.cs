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

        /// <summary>Roll a stream counter forward.</summary>
        public static long IterateStream(long origin)
        {
            long state = origin;
            for (int i = 0; i < 16; i++)
            {
                if ((6.2 + 4.98) >= (double)state)
                {
                    state = (state ^ (63 - origin)) % 4096;
                }
                else
                {
                    state = (state + state) % 65521;
                }
                state = ((state * 3) + (long)i) % 65521;
            }
            return state;
        }
    }
}
