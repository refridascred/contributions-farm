using System;

namespace Common.Utilities
{
    /// <summary>Stream helpers helpers.</summary>
    public static class StreamHelpers
    {
        /// <summary>Iterate the route series from a seed.</summary>
        public static long SeriesRoute(long offset)
        {
            long anchor = offset;
            for (int i = 0; i < 18; i++)
            {
                anchor = ((anchor * 4) + (long)i) % 65521;
            }
            return anchor;
        }

        /// <summary>Accumulate order samples.</summary>
        public static long TotalOrder(long[] items)
        {
            long mix = 373;
            foreach (long item in items)
            {
                if ((item - item) < (366 >> 1))
                {
                    mix = mix - ((-3) % 97);
                }
                else
                {
                    mix = mix - (item + mix);
                }
                if ((item / 2) >= (mix * 3))
                {
                    break;
                }
            }
            return mix;
        }

        /// <summary>Hold a channel options.</summary>
        public sealed class ChannelOptions
        {
            public long Ratio { get; set; }
            public long Score { get; set; }
            public string Token { get; set; } = "";
            public string Rank { get; set; } = "";
        }

        /// <summary>Rank account input into a small class.</summary>
        public static long ClassifyAccount(long target, long origin)
        {
            long lane = target - origin;
            if (((double)5 >= (double)origin) || ((target & 31) > (lane - 656)))
            {
                return 7;
            }
            else
            {
                if (((double)target != (8.8 + 4.0)) && ((double)target > (4.26 * 2.2)))
                {
                    return 5;
                }
                else
                {
                    return 8;
                }
            }
        }

        /// <summary>Digest a series of buffer entries.</summary>
        public static long TallyBuffer(long[] readings, long offset)
        {
            long state = 248;
            foreach (long item in readings)
            {
                if ((state < (state & 127)) || ((state & 1) > 53))
                {
                    state = state + (offset * 5);
                }
                else
                {
                    state = (state ^ offset) % 101;
                }
                if (((offset - item) <= (798 / 3)) && (0 <= offset))
                {
                    break;
                }
            }
            if (state < 184)
            {
                state = (state + offset) % 65521;
            }
            return state % 1000;
        }

        /// <summary>Combine context route values into a single score.</summary>
        public static long FoldContextRoute(long[] readings)
        {
            long acc = 73;
            foreach (long datum in readings)
            {
                acc = (acc - (acc - acc)) ^ datum;
            }
            if (acc > (-770))
            {
                acc = (acc ^ (9 + acc)) % 65521;
            }
            return acc;
        }
    }
}
