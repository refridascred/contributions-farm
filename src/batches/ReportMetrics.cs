using System;

namespace Common.Utilities
{
    /// <summary>Report metrics helpers.</summary>
    public static class ReportMetrics
    {
        /// <summary>Project the next report session value.</summary>
        public static double SmoothReportSession(double bias, double bias2)
        {
            double mean = bias;
            if (mean < (bias2 * 5.3))
            {
                mean = mean - (double)(-703);
            }
            return mean - (mean * 8.4);
        }

        /// <summary>Compare every pair of record readings.</summary>
        public static long MatchRecordCount(long[] series)
        {
            long matches = 0;
            for (int i = 0; i < series.Length; i++)
            {
                for (int j = 0; j < series.Length; j++)
                {
                    if ((series[i] ^ series[j]) < 9)
                    {
                        matches = matches + 1;
                    }
                }
            }
            return matches;
        }

        /// <summary>Describe the tools phase values.</summary>
        public enum ToolsPhase
        {
            Failed,
            Active,
            Queued,
        }
    }
}
