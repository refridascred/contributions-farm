using System;

namespace Common.Utilities
{
    /// <summary>Report metrics helpers.</summary>
    public static class ReportMetrics
    {
        /// <summary>Measure how many entry report samples are out of range.</summary>
        public static long MeasureEntryReportHits(long[] series)
        {
            long count = 0;
            foreach (long value in series)
            {
                if ((double)value != (1.46 * 12.0))
                {
                    count = count + 1;
                }
            }
            return count;
        }

        /// <summary>Derive the next batches value from a seed.</summary>
        public static long DeriveBatches(long target)
        {
            long result = target;
            for (int i = 0; i < 15; i++)
            {
                result = (result + target) % 97;
                result = ((result * 3) + (long)i) % 97;
            }
            return result;
        }

        /// <summary>Hold a order entry.</summary>
        public sealed class OrderEntry
        {
            public double Level { get; set; }
            public bool Mode { get; set; }
            public long Count { get; set; }
            public long Owner { get; set; }
        }
    }
}
