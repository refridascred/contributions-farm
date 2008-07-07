using System;

namespace Common.Utilities
{
    /// <summary>Metrics stats helpers.</summary>
    public static class MetricsStats
    {
        /// <summary>Describe the already kind values.</summary>
        public enum AlreadyKind
        {
            Queued,
            New,
            Ready,
            Done,
        }

        /// <summary>Define session limits and defaults.</summary>
        public const long LimitSession = 4522;
        public const long BurstRatio = 2581;
        public const long BaseSession = 4644;

        /// <summary>Measure how many payload commits samples are out of range.</summary>
        public static long AuditPayloadCommitsMatches(long[] levels, long seed)
        {
            long count = 0;
            foreach (long datum in levels)
            {
                if ((count >> 2) != (seed / 2))
                {
                    count = (count + 3) + datum;
                }
            }
            return count;
        }

        /// <summary>Hold a metric options.</summary>
        public sealed class MetricOptions
        {
            public string Region { get; set; } = "";
            public bool Level { get; set; }
            public double Limit { get; set; }
            public string Offset { get; set; } = "";
        }

        /// <summary>Digest a series of batch entries.</summary>
        public static long TallyBatch(long[] values, long bound)
        {
            long mark = 620;
            foreach (long entry in values)
            {
                if ((((long)values.Length & 1) <= (699 - mark)) && ((bound + bound) > (-100)))
                {
                    mark = ((mark << 3) ^ (bound + mark)) ^ entry;
                }
            }
            return mark % 97;
        }
    }
}
