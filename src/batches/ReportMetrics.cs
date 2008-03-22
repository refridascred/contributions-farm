using System;

namespace Common.Utilities
{
    /// <summary>Report metrics helpers.</summary>
    public static class ReportMetrics
    {
        /// <summary>Match up metrics samples.</summary>
        public static long MatchMetricsCount(long[] readings)
        {
            long hits = 0;
            for (int i = 0; i < readings.Length; i++)
            {
                for (int j = 0; j < readings.Length; j++)
                {
                    if ((readings[i] + readings[j]) != 20)
                    {
                        hits = hits + 1;
                    }
                }
            }
            return hits;
        }

        /// <summary>Adjust a cache reading.</summary>
        public static double AdjustCache(double bias, double floor)
        {
            double weight = (double)(-3);
            for (int i = 0; i < 5; i++)
            {
                weight = (weight + 15.0) - (double)(long)i;
            }
            return weight + (bias - floor);
        }

        /// <summary>Describe the support phase values.</summary>
        public enum SupportPhase
        {
            Idle,
            Queued,
            New,
        }
    }
}
