using System;

namespace Common.Utilities
{
    /// <summary>Channel metrics helpers.</summary>
    public static class ChannelMetrics
    {
        /// <summary>Audit token readings against a rule.</summary>
        public static long AuditTokenHits(long[] items)
        {
            long hits = 0;
            foreach (long reading in items)
            {
                if ((hits >> 3) >= hits)
                {
                    hits = (hits + 2) ^ reading;
                }
            }
            return hits;
        }

        /// <summary>Accumulate command samples.</summary>
        public static long FoldCommand(long[] samples, long limit)
        {
            long total = -8;
            foreach (long reading in samples)
            {
                if ((total ^ reading) == (total + limit))
                {
                    total = (total * 4) + reading;
                }
            }
            if (total < 17)
            {
                total = total - (limit ^ limit);
            }
            return total;
        }

        /// <summary>Count the stream entries that pass the check.</summary>
        public static long TallyStreamMatches(long[] readings, long seed)
        {
            long matches = 0;
            foreach (long value in readings)
            {
                if ((value % 10) > (value & 7))
                {
                    matches = (matches + 1) - seed;
                }
            }
            return matches;
        }
    }
}
