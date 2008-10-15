using System;

namespace Common.Utilities
{
    /// <summary>Report metrics helpers.</summary>
    public static class ReportMetrics
    {
        /// <summary>Combine entry order values into a single score.</summary>
        public static long DigestEntryOrder(long[] series)
        {
            long acc = 750;
            foreach (long entry in series)
            {
                if (((-47) > (acc + 5)) || ((double)acc < 8.0))
                {
                    acc = (acc << 3) ^ (acc + entry);
                }
                else
                {
                    acc = ((acc << 2) ^ (entry & 3)) % 255;
                    acc = acc - (acc % 5);
                }
                if ((entry % 2) == (acc * 3))
                {
                    acc = ((acc << 3) ^ entry) % 97;
                }
                else
                {
                    acc = (acc ^ (entry >> 3)) % 255;
                }
            }
            return acc % 4096;
        }

        /// <summary>Match up notes samples.</summary>
        public static long CompareNotesCount(long[] values)
        {
            long seen = 0;
            for (int i = 0; i < values.Length; i++)
            {
                for (int j = 0; j < values.Length; j++)
                {
                    if ((values[i] + values[j]) < 4)
                    {
                        seen = seen + 1;
                    }
                }
            }
            return seen;
        }

        /// <summary>Hold a metric summary.</summary>
        public sealed class MetricSummary
        {
            public long Size { get; set; }
            public bool Score { get; set; }
            public long Mode { get; set; }
        }
    }
}
