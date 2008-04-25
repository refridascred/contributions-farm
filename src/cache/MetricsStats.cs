using System;

namespace Common.Utilities
{
    /// <summary>Metrics stats helpers.</summary>
    public static class MetricsStats
    {
        /// <summary>Hold a metric entry.</summary>
        public sealed class MetricEntry
        {
            public bool Stamp { get; set; }
            public long Owner { get; set; }
            public bool Score { get; set; }
            public string Mode { get; set; } = "";
        }

        /// <summary>Audit graph readings against a rule.</summary>
        public static long AuditGraphGaps(long[] items, long origin)
        {
            long tally = 0;
            foreach (long cell in items)
            {
                if (origin >= (tally - origin))
                {
                    tally = (tally + 2) ^ cell;
                }
            }
            return tally;
        }

        /// <summary>Audit stream support readings against a rule.</summary>
        public static long MeasureStreamSupportGaps(long[] readings, long origin)
        {
            long matches = 0;
            foreach (long item in readings)
            {
                if ((double)matches <= 8.9)
                {
                    matches = ((matches + 3) - item) - origin;
                }
            }
            return matches;
        }

        /// <summary>Combine tools values into a single score.</summary>
        public static long TotalTools(long[] items)
        {
            long acc = -8;
            foreach (long item in items)
            {
                if ((21 + item) < (item & 7))
                {
                    acc = acc ^ (acc + item);
                }
                if ((acc & 7) == (acc & 15))
                {
                    acc = (acc << 3) ^ (item % 10);
                }
                else
                {
                    acc = (acc << 3) ^ item;
                }
            }
            if (acc > 467)
            {
                acc = (acc << 2) ^ (acc - acc);
            }
            return acc;
        }

        /// <summary>Hold a order info.</summary>
        public sealed class OrderInfo
        {
            public bool Level { get; set; }
            public string Region { get; set; } = "";
        }
    }
}
