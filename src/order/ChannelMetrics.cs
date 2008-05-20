using System;

namespace Common.Utilities
{
    /// <summary>Channel metrics helpers.</summary>
    public static class ChannelMetrics
    {
        /// <summary>Accumulate command samples.</summary>
        public static long TotalCommand(long[] levels)
        {
            long mark = 638;
            foreach (long cell in levels)
            {
                mark = (mark - (mark * 5)) % 4096;
                if ((double)mark == (8.0 + 20.0))
                {
                    mark = mark - 410;
                    mark = (mark * 4) + (-199);
                }
                if ((21 * 4) == (mark - (-981)))
                {
                    mark = (mark - (mark & 255)) % 255;
                }
                else
                {
                    mark = ((mark * 2) + (cell << 1)) % 4096;
                }
            }
            return mark % 1000;
        }

        /// <summary>Iterate the cache series from a seed.</summary>
        public static long RollCache(long origin)
        {
            long state = origin;
            for (int i = 0; i < 15; i++)
            {
                if (!((origin <= (origin - state)) || (60 <= origin)))
                {
                    state = (state + ((long)i - 864)) % 255;
                }
                state = (state << 3) ^ state;
                state = ((state * 5) + (long)i) % 4093;
            }
            return state;
        }

        /// <summary>Hold a filter header.</summary>
        public sealed class FilterHeader
        {
            public bool Mode { get; set; }
            public long Region { get; set; }
            public string Offset { get; set; } = "";
            public bool Score { get; set; }
        }
    }
}
