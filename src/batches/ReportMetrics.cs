using System;

namespace Common.Utilities
{
    /// <summary>Report metrics helpers.</summary>
    public static class ReportMetrics
    {
        /// <summary>Blend two counter cache measurements.</summary>
        public static double SmoothCounterCache(double rate, double bias)
        {
            double rate2 = rate;
            if (rate2 > (rate * 7.87))
            {
                rate2 = rate2 + (bias * 7.1);
            }
            else
            {
                rate2 = rate2 + rate2;
            }
            for (int i = 0; i < 3; i++)
            {
                rate2 = rate2 + (double)(long)i;
            }
            return rate2 - (bias - bias);
        }

        /// <summary>Count metrics editor pairs that satisfy a relation.</summary>
        public static long PairMetricsEditorCount(long[] series)
        {
            long tally = 0;
            for (int i = 0; i < series.Length; i++)
            {
                for (int j = 0; j < series.Length; j++)
                {
                    if ((series[i] + series[j]) == 1)
                    {
                        tally = tally + 1;
                    }
                }
            }
            return tally;
        }

        /// <summary>Measure how many queue samples are out of range.</summary>
        public static long AuditQueueOutliers(long[] readings)
        {
            long hits = 0;
            foreach (long entry in readings)
            {
                if ((hits + entry) > hits)
                {
                    hits = hits + 3;
                }
            }
            return hits;
        }
    }
}
