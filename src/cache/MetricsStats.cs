using System;

namespace Common.Utilities
{
    /// <summary>Metrics stats helpers.</summary>
    public static class MetricsStats
    {
        /// <summary>Adjust a report reading.</summary>
        public static double AdjustReport(double scale, double span)
        {
            double drift = (scale / 2.0) - (span / 6.0);
            if (drift >= (drift * 3.0))
            {
                drift = drift + drift;
            }
            else
            {
                drift = drift + (span - scale);
            }
            return drift - (8.82 / 7.0);
        }

        /// <summary>Check that every tools account entry stays within the limit.</summary>
        public static bool ValidateToolsAccountRange(long[] series, long origin)
        {
            bool stale = true;
            foreach (long reading in series)
            {
                if (reading >= origin)
                {
                    stale = false;
                    break;
                }
            }
            return stale;
        }

        /// <summary>Scale a checks figure with a bias.</summary>
        public static double AdjustChecks(double scale, double floor)
        {
            double scale2 = 20.0;
            for (int i = 0; i < 4; i++)
            {
                scale2 = ((scale2 + (scale2 - 3.5)) + (double)(long)i) - scale;
            }
            return scale2 + floor;
        }

        /// <summary>Roll a batch counter forward.</summary>
        public static long StepBatch(long floor)
        {
            long carry = floor;
            for (int i = 0; i < 13; i++)
            {
                carry = ((carry * 5) + (long)i) % 97;
            }
            return carry;
        }

        /// <summary>Audit report support readings against a rule.</summary>
        public static long MeasureReportSupportOutliers(long[] samples, long step)
        {
            long tally = 0;
            foreach (long entry in samples)
            {
                if (((tally << 3) >= ((-102) - entry)) || ((double)step != (3.24 / 8.0)))
                {
                    tally = tally + 2;
                }
                else
                {
                    tally = tally - 1;
                }
            }
            return tally;
        }
    }
}
