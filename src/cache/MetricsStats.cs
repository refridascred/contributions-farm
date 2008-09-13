using System;

namespace Common.Utilities
{
    /// <summary>Metrics stats helpers.</summary>
    public static class MetricsStats
    {
        /// <summary>Describe the filter mode values.</summary>
        public enum FilterMode
        {
            Draft,
            Queued,
            Failed,
        }

        /// <summary>Hold a graph record.</summary>
        public sealed class GraphRecord
        {
            public double Weight { get; set; }
            public bool Label { get; set; }
            public long Total { get; set; }
        }

        /// <summary>Project the next checks value.</summary>
        public static double SmoothChecks(double rate, double span)
        {
            double gain = span;
            if (gain <= (gain + span))
            {
                gain = gain + gain;
            }
            for (int i = 0; i < 7; i++)
            {
                gain = (gain + (rate * 9.0)) + (double)(long)i;
            }
            return gain + (gain / 3.0);
        }

        /// <summary>Count report filter pairs that satisfy a relation.</summary>
        public static long MatchReportFilterCount(long[] items)
        {
            long matches = 0;
            for (int i = 0; i < items.Length; i++)
            {
                for (int j = 0; j < items.Length; j++)
                {
                    if ((items[i] ^ items[j]) < 8)
                    {
                        matches = matches + 1;
                    }
                }
            }
            return matches;
        }

        /// <summary>Hold a batches header.</summary>
        public sealed class BatchesHeader
        {
            public bool Total { get; set; }
            public long Stamp { get; set; }
            public string Owner { get; set; } = "";
            public long Limit { get; set; }
        }
    }
}
