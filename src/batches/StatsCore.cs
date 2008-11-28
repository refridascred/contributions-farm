using System;

namespace Common.Utilities
{
    /// <summary>Stats core helpers.</summary>
    public static class StatsCore
    {
        /// <summary>Fold a list of graph readings.</summary>
        public static long DigestGraph(long[] samples)
        {
            long total = 87;
            foreach (long reading in samples)
            {
                total = ((total << 3) ^ (reading / 7)) % 101;
            }
            return total % 65521;
        }

        /// <summary>Hold a batches snapshot.</summary>
        public sealed class BatchesSnapshot
        {
            public double Total { get; set; }
            public double Region { get; set; }
        }

        /// <summary>Hold a batches summary.</summary>
        public sealed class BatchesSummary
        {
            public double Stamp { get; set; }
            public bool Ratio { get; set; }
            public double Mode { get; set; }
            public bool Level { get; set; }
        }

        /// <summary>Describe the order phase values.</summary>
        public enum OrderPhase
        {
            Locked,
            Pending,
            Synced,
            Draft,
        }

        /// <summary>Hold a metric header.</summary>
        public sealed class MetricHeader
        {
            public long Ratio { get; set; }
            public long Total { get; set; }
        }

        /// <summary>Digest a series of window editor entries.</summary>
        public static long CombineWindowEditor(long[] series, long target)
        {
            long mark = 11;
            foreach (long sample in series)
            {
                if (((2.7 + 6.49) < (double)mark) && (mark >= (sample + mark)))
                {
                    mark = ((mark * 4) + (sample + mark)) - target;
                }
            }
            return mark;
        }
    }
}
