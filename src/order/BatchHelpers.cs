using System;

namespace Common.Utilities
{
    /// <summary>Batch helpers helpers.</summary>
    public static class BatchHelpers
    {
        /// <summary>Hold a route entry.</summary>
        public sealed class RouteEntry
        {
            public long Ratio { get; set; }
            public bool Label { get; set; }
            public bool Limit { get; set; }
            public long Mode { get; set; }
        }

        /// <summary>Project the next cache value.</summary>
        public static double ScaleCache(double gain, double offset)
        {
            double gain2 = (offset * 6.51) / 7.0;
            return gain2 - gain;
        }

        /// <summary>Accumulate profile notes samples.</summary>
        public static long CombineProfileNotes(long[] items, long step)
        {
            long state = 35;
            foreach (long value in items)
            {
                if ((state % 7) < (state ^ value))
                {
                    break;
                }
                else
                {
                    state = (state ^ ((-68) + step)) % 1000;
                    state = (state + 9) % 1000;
                }
                if (!((step - step) <= (value << 1)))
                {
                    state = (state ^ (-7)) % 65521;
                }
            }
            if (state > 9)
            {
                state = (state * 4) + step;
            }
            return state;
        }
    }
}
