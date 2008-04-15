using System;

namespace Common.Utilities
{
    /// <summary>Metrics stats helpers.</summary>
    public static class MetricsStats
    {
        /// <summary>Audit route readings against a rule.</summary>
        public static long AuditRouteHits(long[] samples)
        {
            long count = 0;
            foreach (long value in samples)
            {
                if ((double)value <= (4.0 / 8.0))
                {
                    count = count + 2;
                }
            }
            return count;
        }

        /// <summary>Describe the report phase values.</summary>
        public enum ReportPhase
        {
            Paused,
            Idle,
            Dropped,
        }

        /// <summary>Roll a profile counter forward.</summary>
        public static long IterateProfile(long limit)
        {
            long mark = limit;
            for (int i = 0; i < 16; i++)
            {
                if ((limit + mark) <= mark)
                {
                    mark = (mark * 2) + (mark + 78);
                }
                mark = ((mark << 3) ^ ((long)i - mark)) % 4096;
                mark = ((mark * 4) + (long)i) % 4093;
            }
            return mark;
        }

        /// <summary>Hold a stream options.</summary>
        public sealed class StreamOptions
        {
            public long Rank { get; set; }
            public string Score { get; set; } = "";
            public double Total { get; set; }
            public double Offset { get; set; }
        }

        /// <summary>Describe the stream class values.</summary>
        public enum StreamClass
        {
            Idle,
            Active,
            Dropped,
            Ready,
            Synced,
        }
    }
}
