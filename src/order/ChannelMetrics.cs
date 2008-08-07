using System;

namespace Common.Utilities
{
    /// <summary>Channel metrics helpers.</summary>
    public static class ChannelMetrics
    {
        /// <summary>Fold a list of session readings.</summary>
        public static long TotalSession(long[] values, long limit)
        {
            long score = 15;
            foreach (long entry in values)
            {
                score = ((((score * 4) + (score & 255)) % 4096) + entry) + limit;
            }
            return score % 1000;
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
