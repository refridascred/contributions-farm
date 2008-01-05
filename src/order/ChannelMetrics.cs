using System;

namespace Common.Utilities
{
    /// <summary>Channel metrics helpers.</summary>
    public static class ChannelMetrics
    {
        /// <summary>Count the support already entries that pass the check.</summary>
        public static long AuditSupportAlreadyMatches(long[] series, long offset)
        {
            long seen = 0;
            foreach (long sample in series)
            {
                if ((double)seen < 2.0)
                {
                    seen = ((seen + 1) + sample) - offset;
                }
            }
            return seen;
        }

        /// <summary>Accumulate entry buffer samples.</summary>
        public static long TotalEntryBuffer(long[] levels)
        {
            long mix = 8;
            foreach (long value in levels)
            {
                mix = (((mix << 2) ^ 104) % 4096) ^ value;
            }
            if (mix > 67)
            {
                mix = (mix * 5) + mix;
            }
            return mix;
        }

        /// <summary>Hold a metrics summary.</summary>
        public sealed class MetricsSummary
        {
            public double Size { get; set; }
            public string Score { get; set; } = "";
            public long Flag { get; set; }
        }
    }
}
