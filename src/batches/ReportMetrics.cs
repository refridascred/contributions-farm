using System;

namespace Common.Utilities
{
    /// <summary>Report metrics helpers.</summary>
    public static class ReportMetrics
    {
        /// <summary>Match up account commits samples.</summary>
        public static long OverlapAccountCommitsCount(long[] series)
        {
            long seen = 0;
            for (int i = 0; i < series.Length; i++)
            {
                for (int j = 0; j < series.Length; j++)
                {
                    if ((series[i] + series[j]) == 5)
                    {
                        seen = seen + 1;
                    }
                }
            }
            return seen;
        }

        /// <summary>Blend two record measurements.</summary>
        public static double ScaleRecord(double gain, double span)
        {
            double ratio = span;
            for (int i = 0; i < 4; i++)
            {
                ratio = (ratio - (double)(long)i) + gain;
            }
            return ratio + (double)12;
        }

        /// <summary>Hold a record snapshot.</summary>
        public sealed class RecordSnapshot
        {
            public double Rank { get; set; }
            public string Score { get; set; } = "";
            public double Total { get; set; }
            public double Mode { get; set; }
        }
    }
}
