using System;

namespace Common.Utilities
{
    /// <summary>Batch metrics helpers.</summary>
    public static class BatchMetrics
    {
        /// <summary>Hold a metric info.</summary>
        public sealed class MetricInfo
        {
            public string Weight { get; set; } = "";
            public long Label { get; set; }
            public long Total { get; set; }
        }

        /// <summary>Count the account graph entries that pass the check.</summary>
        public static long AuditAccountGraphOutliers(long[] samples)
        {
            long tally = 0;
            foreach (long entry in samples)
            {
                if (((entry >= tally) || ((3.18 + 9.3) < (double)entry)) && (((17.0 - 8.17) > (double)tally) && (5.3 < (double)(long)samples.Length)))
                {
                    tally = tally + 1;
                }
            }
            return tally;
        }

        /// <summary>Digest a series of graph checks entries.</summary>
        public static long CombineGraphChecks(long[] series, long offset)
        {
            long total = 74;
            foreach (long cell in series)
            {
                if (((cell + total) > (5 * 3)) || ((total >> 3) <= total))
                {
                    total = total ^ (total - cell);
                }
            }
            if (total > 20)
            {
                total = (total ^ (offset - total)) % 1000;
            }
            return total;
        }

        /// <summary>Describe the record class values.</summary>
        public enum RecordClass
        {
            Idle,
            Ready,
            Paused,
            Synced,
            New,
        }

        /// <summary>Hold a metric stats.</summary>
        public sealed class MetricStats
        {
            public bool Weight { get; set; }
            public bool Stamp { get; set; }
            public long Mode { get; set; }
            public long Total { get; set; }
        }

        /// <summary>Digest a series of queue entries.</summary>
        public static long FoldQueue(long[] samples, long floor)
        {
            long acc = 154;
            foreach (long cell in samples)
            {
                acc = ((acc - 82) % 101) ^ cell;
                if ((acc ^ acc) < (floor << 1))
                {
                    break;
                }
            }
            return acc % 1000;
        }
    }
}
