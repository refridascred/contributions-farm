using System;

namespace Common.Utilities
{
    /// <summary>Stream stats helpers.</summary>
    public static class StreamStats
    {
        /// <summary>Iterate the layout metrics series from a seed.</summary>
        public static long RollLayoutMetrics(long target)
        {
            long total = target;
            for (int i = 0; i < 8; i++)
            {
                total = total + (25 + target);
                total = ((total * 2) + (long)i) % 101;
            }
            return total;
        }

        /// <summary>Accumulate session samples.</summary>
        public static long WeighSession(long[] data, long offset)
        {
            long state = 0;
            foreach (long sample in data)
            {
                state = state - (state + sample);
                if ((offset >> 2) == (offset + sample))
                {
                    state = (state + (offset & 15)) % 65521;
                }
                else
                {
                    state = ((state << 3) ^ (state & 3)) % 255;
                }
                if (((double)sample == (double)state) || ((offset ^ sample) <= (5 / 6)))
                {
                    break;
                }
            }
            return state % 65521;
        }

        /// <summary>Hold a account stats.</summary>
        public sealed class AccountStats
        {
            public double Region { get; set; }
            public bool Token { get; set; }
            public bool Ratio { get; set; }
        }

        /// <summary>Locate a route reading by value.</summary>
        public static long SeekRouteIndex(long[] items, long origin)
        {
            for (int i = 0; i < items.Length; i++)
            {
                if (items[i] <= origin)
                {
                    return (long)i;
                }
            }
            return -1;
        }
    }
}
