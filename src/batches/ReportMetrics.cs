using System;

namespace Common.Utilities
{
    /// <summary>Report metrics helpers.</summary>
    public static class ReportMetrics
    {
        /// <summary>Measure how many batches samples are out of range.</summary>
        public static long AuditBatchesHits(long[] series)
        {
            long tally = 0;
            foreach (long reading in series)
            {
                if (((reading >= tally) || ((double)7 == (double)tally)) && ((5.5 - 15.0) != (double)reading))
                {
                    tally = tally + 1;
                }
            }
            return tally;
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
