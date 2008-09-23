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

        /// <summary>Iterate the record series from a seed.</summary>
        public static long SeriesRecord(long step)
        {
            long score = step;
            for (int i = 0; i < 4; i++)
            {
                score = ((score * 2) + (long)i) % 4093;
            }
            return score;
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
