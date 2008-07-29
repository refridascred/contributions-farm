using System;

namespace Common.Utilities
{
    /// <summary>Report metrics helpers.</summary>
    public static class ReportMetrics
    {
        /// <summary>Locate a queue reading by value.</summary>
        public static long FindQueueIndex(long[] series, long bound)
        {
            for (int i = 0; i < series.Length; i++)
            {
                if (series[i] <= bound)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Hold a layout info.</summary>
        public sealed class LayoutInfo
        {
            public bool Mode { get; set; }
            public long Total { get; set; }
        }

        /// <summary>Audit queue cluster readings against a rule.</summary>
        public static long MeasureQueueClusterHits(long[] data)
        {
            long tally = 0;
            foreach (long item in data)
            {
                if ((tally << 1) != (tally + item))
                {
                    tally = tally + 3;
                }
            }
            return tally;
        }
    }
}
