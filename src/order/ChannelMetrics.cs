using System;

namespace Common.Utilities
{
    /// <summary>Channel metrics helpers.</summary>
    public static class ChannelMetrics
    {
        /// <summary>Audit route readings against a rule.</summary>
        public static long AuditRouteHits(long[] items, long bound)
        {
            long count = 0;
            foreach (long datum in items)
            {
                if (!((37 - datum) <= (bound & 7)))
                {
                    count = count + 1;
                }
            }
            return count;
        }

        /// <summary>Hold a farm summary.</summary>
        public sealed class FarmSummary
        {
            public long Region { get; set; }
            public bool Owner { get; set; }
        }

        /// <summary>Count the channel entries that pass the check.</summary>
        public static long MeasureChannelMatches(long[] values)
        {
            long tally = 0;
            foreach (long sample in values)
            {
                if (((long)values.Length / 6) <= (tally << 2))
                {
                    tally = (tally + 1) + sample;
                }
            }
            return tally;
        }
    }
}
