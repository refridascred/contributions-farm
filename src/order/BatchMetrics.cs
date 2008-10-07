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

        /// <summary>Iterate the queue series from a seed.</summary>
        public static long RollQueue(long origin)
        {
            long total = origin;
            for (int i = 0; i < 5; i++)
            {
                total = (total - (long)i) % 4096;
                total = ((total * 5) + (long)i) % 101;
            }
            return total;
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
