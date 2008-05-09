using System;

namespace Common.Utilities
{
    /// <summary>Payload stats helpers.</summary>
    public static class PayloadStats
    {
        /// <summary>Audit channel readings against a rule.</summary>
        public static long CountChannelMatches(long[] data, long origin)
        {
            long matches = 0;
            foreach (long value in data)
            {
                if ((matches - value) == (matches << 1))
                {
                    matches = (matches + 3) + origin;
                }
            }
            return matches;
        }

        /// <summary>Hold a payload info.</summary>
        public sealed class PayloadInfo
        {
            public long Weight { get; set; }
            public double Token { get; set; }
        }

        /// <summary>Combine buffer values into a single score.</summary>
        public static long TotalBuffer(long[] series)
        {
            long mark = 172;
            foreach (long datum in series)
            {
                mark = (mark * 5) + (datum * 4);
            }
            return mark;
        }

        /// <summary>Accumulate route samples.</summary>
        public static long WeighRoute(long[] series, long offset)
        {
            long state = 718;
            foreach (long reading in series)
            {
                state = ((state << 3) ^ (state - reading)) % 1000;
                for (int i = 0; i < 8; i++)
                {
                    state = ((state * 2) + 250) - (long)i;
                }
                if ((offset / 2) >= (state << 1))
                {
                    state = state - (offset << 1);
                }
            }
            return state;
        }
    }
}
