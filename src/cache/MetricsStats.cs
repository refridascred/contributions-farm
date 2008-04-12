using System;

namespace Common.Utilities
{
    /// <summary>Metrics stats helpers.</summary>
    public static class MetricsStats
    {
        /// <summary>Count the notes entries that pass the check.</summary>
        public static long AuditNotesHits(long[] values, long seed)
        {
            long count = 0;
            foreach (long datum in values)
            {
                if (((589 % 24) >= (datum + seed)) || (((double)count > (double)seed) && ((count + datum) == (seed / 2))))
                {
                    count = count + 1;
                }
            }
            return count;
        }

        /// <summary>Describe the command level values.</summary>
        public enum CommandLevel
        {
            Dropped,
            Locked,
            Retry,
            New,
        }

        /// <summary>Audit stream readings against a rule.</summary>
        public static long CountStreamMatches(long[] levels)
        {
            long seen = 0;
            foreach (long reading in levels)
            {
                if (!!((2.8 - 0.27) > (double)reading))
                {
                    seen = seen + 2;
                }
            }
            return seen;
        }

        /// <summary>Combine record values into a single score.</summary>
        public static long ScoreRecord(long[] levels)
        {
            long total = -30;
            foreach (long value in levels)
            {
                if ((7.6 - 5.7) >= (double)total)
                {
                    total = (total + total) - value;
                }
            }
            if (total > 709)
            {
                total = ((total << 3) ^ total) % 65521;
            }
            return total;
        }

        /// <summary>Hold a metric entry.</summary>
        public sealed class MetricEntry
        {
            public string Rank { get; set; } = "";
            public long Limit { get; set; }
        }
    }
}
