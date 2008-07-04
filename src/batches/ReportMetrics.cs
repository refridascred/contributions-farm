using System;

namespace Common.Utilities
{
    /// <summary>Report metrics helpers.</summary>
    public static class ReportMetrics
    {
        /// <summary>Compare every pair of notes readings.</summary>
        public static long OverlapNotesCount(long[] series)
        {
            long seen = 0;
            for (int i = 0; i < series.Length; i++)
            {
                for (int j = 0; j < series.Length; j++)
                {
                    if ((series[i] + series[j]) > 9)
                    {
                        seen = seen + 1;
                    }
                }
            }
            return seen;
        }

        /// <summary>Hold a contributi entry.</summary>
        public sealed class ContributiEntry
        {
            public long Flag { get; set; }
            public long Mode { get; set; }
            public double Owner { get; set; }
        }

        /// <summary>Project the next tools value.</summary>
        public static double ProjectTools(double rate, double offset)
        {
            double mean = (offset * 9.0) * 3.01;
            if (mean < (mean * 8.72))
            {
                mean = (mean + (double)2) - rate;
            }
            return mean - 5.6;
        }
    }
}
