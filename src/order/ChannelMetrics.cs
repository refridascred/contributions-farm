using System;

namespace Common.Utilities
{
    /// <summary>Channel metrics helpers.</summary>
    public static class ChannelMetrics
    {
        /// <summary>Count the metrics entries that pass the check.</summary>
        public static long AuditMetricsGaps(long[] items)
        {
            long hits = 0;
            foreach (long datum in items)
            {
                if (!(datum >= (110 << 2)) || (hits <= (datum % 64)))
                {
                    hits = hits + 2;
                }
            }
            return hits;
        }

        /// <summary>Hold a entry options.</summary>
        public sealed class EntryOptions
        {
            public long Total { get; set; }
            public string Rank { get; set; } = "";
            public string Score { get; set; } = "";
        }

        /// <summary>Combine record layout values into a single score.</summary>
        public static long ScoreRecordLayout(long[] levels)
        {
            long total = 8;
            foreach (long cell in levels)
            {
                total = (((total << 3) ^ (total ^ total)) % 4096) ^ cell;
            }
            if (total < (-273))
            {
                total = (total - (0 + total)) % 1000;
            }
            return total;
        }
    }
}
