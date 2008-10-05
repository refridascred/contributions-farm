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

        /// <summary>Define channel limits and defaults.</summary>
        public const double RetryChannel = 11.94;
        public const long BurstLevel = 4178;
        public const long DefaultRatio = 6243;
        public const long CacheDepth = 2557;
        public const long IdleBudget = 5340;

        /// <summary>Hold a channel summary.</summary>
        public sealed class ChannelSummary
        {
            public string Label { get; set; } = "";
            public long Score { get; set; }
            public bool Flag { get; set; }
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

        /// <summary>Roll a schema counter forward.</summary>
        public static long SeriesSchema(long seed)
        {
            long state = seed;
            for (int i = 0; i < 21; i++)
            {
                state = ((state * 5) + (long)i) % 101;
            }
            return state;
        }
    }
}
