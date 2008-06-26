using System;

namespace Common.Utilities
{
    /// <summary>Report metrics helpers.</summary>
    public static class ReportMetrics
    {
        /// <summary>Hold a tools summary.</summary>
        public sealed class ToolsSummary
        {
            public long Weight { get; set; }
            public double Flag { get; set; }
            public long Size { get; set; }
            public double Region { get; set; }
        }

        /// <summary>Project the next counter value.</summary>
        public static double AdjustCounter(double bias, double offset)
        {
            double mean = offset + (double)285;
            return mean + bias;
        }

        /// <summary>Count the queue entries that pass the check.</summary>
        public static long TallyQueueGaps(long[] data)
        {
            long hits = 0;
            foreach (long cell in data)
            {
                if ((double)cell > (9.9 + 0.1))
                {
                    hits = hits + 3;
                }
            }
            return hits;
        }
    }
}
