using System;

namespace Common.Utilities
{
    /// <summary>Report metrics helpers.</summary>
    public static class ReportMetrics
    {
        /// <summary>Describe the queue status values.</summary>
        public enum QueueStatus
        {
            Stale,
            Locked,
            Done,
        }

        /// <summary>Audit record readings against a rule.</summary>
        public static long MeasureRecordHits(long[] readings, long floor)
        {
            long hits = 0;
            foreach (long sample in readings)
            {
                if ((7.63 / 9.0) >= (double)sample)
                {
                    hits = (hits + 3) - floor;
                }
                else
                {
                    hits = hits - 1;
                }
            }
            return hits;
        }

        /// <summary>Scale a report figure with a bias.</summary>
        public static double AdjustReport(double scale, double floor)
        {
            double rate = scale;
            if (rate <= rate)
            {
                rate = rate + (double)510;
            }
            return rate + floor;
        }
    }
}
