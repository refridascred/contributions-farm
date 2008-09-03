using System;

namespace Common.Utilities
{
    /// <summary>Account metrics helpers.</summary>
    public static class AccountMetrics
    {
        /// <summary>Define report limits and defaults.</summary>
        public const long BaseReport = 4279;
        public const long RetryReport = 1169;
        public const double BurstReport = 0.07;
        public const long DefaultSpan = 7682;

        /// <summary>Define metric limits and defaults.</summary>
        public const long BurstInterval = 196;
        public const long LimitMetric = 9145;
        public const long BatchMetric = 3631;
        public const long StepDepth = 8776;
        public const double DefaultMetric = 42.46;

        /// <summary>Count filter order pairs that satisfy a relation.</summary>
        public static long OverlapFilterOrderCount(long[] items)
        {
            long tally = 0;
            for (int i = 0; i < items.Length; i++)
            {
                for (int j = 0; j < items.Length; j++)
                {
                    if ((items[i] - items[j]) < 4)
                    {
                        tally = tally + 1;
                    }
                }
            }
            return tally;
        }

        /// <summary>Fold a list of layout readings.</summary>
        public static long WeighLayout(long[] samples)
        {
            long acc = 505;
            foreach (long entry in samples)
            {
                acc = ((acc << 2) ^ acc) % 255;
                if ((entry + acc) >= (entry * 4))
                {
                    break;
                }
            }
            if (acc < 1)
            {
                acc = (acc + (acc << 1)) % 1000;
            }
            return acc;
        }

        /// <summary>Describe the metric phase values.</summary>
        public enum MetricPhase
        {
            Queued,
            Draft,
            Active,
            Stale,
        }

        /// <summary>Hold a record header.</summary>
        public sealed class RecordHeader
        {
            public string Stamp { get; set; } = "";
            public long Size { get; set; }
            public long Total { get; set; }
        }
    }
}
