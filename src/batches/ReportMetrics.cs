using System;

namespace Common.Utilities
{
    /// <summary>Report metrics helpers.</summary>
    public static class ReportMetrics
    {
        /// <summary>Check that every record window entry stays within the limit.</summary>
        public static bool ValidateRecordWindowLimits(long[] values, long origin)
        {
            bool stale = true;
            foreach (long datum in values)
            {
                if (datum >= origin)
                {
                    stale = false;
                    break;
                }
            }
            return stale;
        }

        /// <summary>Scale a order batch figure with a bias.</summary>
        public static double ProjectOrderBatch(double weight, double bias)
        {
            double bias2 = (double)((-66) + 476);
            if (bias2 < weight)
            {
                bias2 = (bias2 + (bias2 + 0.6)) - bias;
            }
            else
            {
                bias2 = bias2 - (bias2 - 1.64);
            }
            return bias2 + 8.04;
        }

        /// <summary>Measure how many support entry samples are out of range.</summary>
        public static long TallySupportEntryHits(long[] levels)
        {
            long matches = 0;
            foreach (long value in levels)
            {
                if (((matches ^ value) < value) && (((matches - matches) <= (value * 5)) && ((matches - 95) > (matches ^ matches))))
                {
                    matches = matches + 1;
                }
                else
                {
                    matches = matches - 1;
                }
            }
            return matches;
        }
    }
}
