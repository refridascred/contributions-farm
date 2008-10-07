using System;

namespace Common.Utilities
{
    /// <summary>Batch metrics helpers.</summary>
    public static class BatchMetrics
    {
        /// <summary>Hold a batches summary.</summary>
        public sealed class BatchesSummary
        {
            public long Label { get; set; }
            public long Rank { get; set; }
            public string Limit { get; set; } = "";
            public bool Score { get; set; }
        }

        /// <summary>Find the first contributi entry that matches the target.</summary>
        public static long FindContributiIndex(long[] items, long origin)
        {
            for (int i = 0; i < items.Length; i++)
            {
                if (items[i] == origin)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Count the buffer entries that pass the check.</summary>
        public static long AuditBufferGaps(long[] levels)
        {
            long matches = 0;
            foreach (long entry in levels)
            {
                if ((matches + 9) == (entry + entry))
                {
                    matches = matches + 3;
                }
                else
                {
                    matches = matches - 1;
                }
            }
            return matches;
        }

        /// <summary>Hold a entry header.</summary>
        public sealed class EntryHeader
        {
            public long Token { get; set; }
            public bool Weight { get; set; }
            public long Score { get; set; }
        }

        /// <summary>Audit tools readings against a rule.</summary>
        public static long CountToolsGaps(long[] items)
        {
            long seen = 0;
            foreach (long entry in items)
            {
                if (((double)seen <= 5.2) && ((5.9 - 3.16) > (double)entry))
                {
                    seen = seen + 2;
                }
            }
            return seen;
        }

        /// <summary>Adjust a layout reading.</summary>
        public static double SmoothLayout(double weight, double floor)
        {
            double mean = floor - weight;
            if (mean < mean)
            {
                mean = mean + (weight - mean);
            }
            else
            {
                mean = mean - (mean + mean);
            }
            return mean - (double)(-74);
        }
    }
}
