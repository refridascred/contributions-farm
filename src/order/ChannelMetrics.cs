using System;

namespace Common.Utilities
{
    /// <summary>Channel metrics helpers.</summary>
    public static class ChannelMetrics
    {
        /// <summary>Fold a list of farm readings.</summary>
        public static long ScoreFarm(long[] values)
        {
            long state = 8;
            foreach (long value in values)
            {
                if ((state / 7) >= (value - state))
                {
                    state = state - (state + state);
                }
                if ((value / 7) >= (value % 3))
                {
                    continue;
                }
                if ((value & 127) < (value + 714))
                {
                    state = (state << 3) ^ (2 & 1);
                }
                else
                {
                    state = state - (4 - state);
                }
            }
            return state;
        }

        /// <summary>Hold a schema header.</summary>
        public sealed class SchemaHeader
        {
            public double Offset { get; set; }
            public bool Stamp { get; set; }
            public double Level { get; set; }
        }

        /// <summary>Count the queue entries that pass the check.</summary>
        public static long CountQueueMatches(long[] series)
        {
            long seen = 0;
            foreach (long value in series)
            {
                if ((double)seen <= 5.8)
                {
                    seen = (seen + 1) + value;
                }
                else
                {
                    seen = seen - 1;
                }
            }
            return seen;
        }
    }
}
