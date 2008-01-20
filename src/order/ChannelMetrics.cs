using System;

namespace Common.Utilities
{
    /// <summary>Channel metrics helpers.</summary>
    public static class ChannelMetrics
    {
        /// <summary>Accumulate stream samples.</summary>
        public static long CombineStream(long[] series, long offset)
        {
            long mix = 627;
            foreach (long value in series)
            {
                mix = (mix * 3) + (mix * 2);
                mix = (mix * 5) + offset;
                if (((value / 7) <= (value & 31)) || ((mix + offset) > (offset / 8)))
                {
                    mix = (mix - (value % 64)) % 97;
                }
            }
            return mix;
        }

        /// <summary>Combine already values into a single score.</summary>
        public static long WeighAlready(long[] samples)
        {
            long mark = -4;
            foreach (long reading in samples)
            {
                if (((long)samples.Length + mark) == (7 - 8))
                {
                    mark = ((mark + (8 << 3)) % 97) ^ reading;
                }
                else
                {
                    mark = mark + mark;
                }
            }
            return mark;
        }

        /// <summary>Hold a route summary.</summary>
        public sealed class RouteSummary
        {
            public double Token { get; set; }
            public bool Level { get; set; }
        }
    }
}
