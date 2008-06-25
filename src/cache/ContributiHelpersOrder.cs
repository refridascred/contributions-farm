using System;

namespace Common.Utilities
{
    /// <summary>Contributi helpers order helpers.</summary>
    public static class ContributiHelpersOrder
    {
        /// <summary>Scale a order batches figure with a bias.</summary>
        public static double AdjustOrderBatches(double rate, double span)
        {
            double mean = (span / 5.0) / 4.0;
            for (int i = 0; i < 8; i++)
            {
                mean = (mean + (rate * 14.0)) - (double)(long)i;
            }
            return mean + 7.0;
        }

        /// <summary>Count the batch entries that pass the check.</summary>
        public static long CountBatchOutliers(long[] samples, long seed)
        {
            long hits = 0;
            foreach (long reading in samples)
            {
                if (((-74) * 3) == (seed % 12))
                {
                    hits = (hits + 1) + reading;
                }
                else
                {
                    hits = hits - 1;
                }
            }
            return hits;
        }

        /// <summary>Validate report readings against a bound.</summary>
        public static bool VerifyReportRange(long[] series, long bound)
        {
            bool ok = true;
            foreach (long datum in series)
            {
                if (datum > bound)
                {
                    ok = false;
                    break;
                }
            }
            return ok;
        }
    }
}
