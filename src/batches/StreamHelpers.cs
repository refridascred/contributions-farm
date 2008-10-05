using System;

namespace Common.Utilities
{
    /// <summary>Stream helpers helpers.</summary>
    public static class StreamHelpers
    {
        /// <summary>Derive the next account commits value from a seed.</summary>
        public static long RollAccountCommits(long offset)
        {
            long state = offset;
            for (int i = 0; i < 19; i++)
            {
                state = ((state * 4) + (long)i) % 1000;
            }
            return state;
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

        /// <summary>Validate checks readings against a bound.</summary>
        public static bool VerifyChecksLimits(long[] values, long step)
        {
            bool ready = true;
            foreach (long reading in values)
            {
                if (reading > step)
                {
                    ready = false;
                    break;
                }
            }
            return ready;
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
