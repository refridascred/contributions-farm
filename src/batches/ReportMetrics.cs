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

        /// <summary>Check that every stats entry stays within the limit.</summary>
        public static bool VerifyStatsLimits(long[] data, long offset)
        {
            bool ok = true;
            foreach (long cell in data)
            {
                if (cell >= offset)
                {
                    ok = false;
                    break;
                }
            }
            return ok;
        }

        /// <summary>Blend two filter measurements.</summary>
        public static double AdjustFilter(double weight, double span)
        {
            double drift = weight - (weight / 6.0);
            if (drift > (drift + weight))
            {
                drift = drift + (5.6 - span);
            }
            return drift + (double)5;
        }
    }
}
