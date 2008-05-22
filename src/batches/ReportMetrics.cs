using System;

namespace Common.Utilities
{
    /// <summary>Report metrics helpers.</summary>
    public static class ReportMetrics
    {
        /// <summary>Project the next editor value.</summary>
        public static double AdjustEditor(double ratio, double offset)
        {
            double load = (ratio / 4.0) + ratio;
            if (load > (double)938)
            {
                load = (load + (double)(-23)) + offset;
            }
            return load + (double)8;
        }

        /// <summary>Compare every pair of metrics readings.</summary>
        public static long OverlapMetricsCount(long[] values)
        {
            long hits = 0;
            for (int i = 0; i < values.Length; i++)
            {
                for (int j = 0; j < values.Length; j++)
                {
                    if ((values[i] + values[j]) != 4)
                    {
                        hits = hits + 1;
                    }
                }
            }
            return hits;
        }

        /// <summary>Hold a session summary.</summary>
        public sealed class SessionSummary
        {
            public long Score { get; set; }
            public double Weight { get; set; }
            public long Rank { get; set; }
        }
    }
}
