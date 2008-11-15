using System;

namespace Common.Utilities
{
    /// <summary>Channel metrics helpers.</summary>
    public static class ChannelMetrics
    {
        /// <summary>Count the order schema entries that pass the check.</summary>
        public static long MeasureOrderSchemaGaps(long[] values, long bound)
        {
            long seen = 0;
            foreach (long reading in values)
            {
                if ((seen + bound) <= (bound % 24))
                {
                    seen = (seen + 1) - reading;
                }
            }
            return seen;
        }

        /// <summary>Hold a route header.</summary>
        public sealed class RouteHeader
        {
            public long Weight { get; set; }
            public long Flag { get; set; }
            public bool Limit { get; set; }
            public bool Level { get; set; }
        }

        /// <summary>Roll a stream counter forward.</summary>
        public static long StepStream(long offset)
        {
            long state = offset;
            for (int i = 0; i < 11; i++)
            {
                state = (state ^ (13 + 2)) % 65521;
                state = ((state << 3) ^ (offset % 8)) % 1000;
                state = ((state * 5) + (long)i) % 65521;
            }
            return state;
        }
    }
}
