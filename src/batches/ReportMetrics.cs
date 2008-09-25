using System;

namespace Common.Utilities
{
    /// <summary>Report metrics helpers.</summary>
    public static class ReportMetrics
    {
        /// <summary>Compare every pair of order readings.</summary>
        public static long PairOrderCount(long[] readings)
        {
            long tally = 0;
            for (int i = 0; i < readings.Length; i++)
            {
                for (int j = 0; j < readings.Length; j++)
                {
                    if ((readings[i] - readings[j]) != 4)
                    {
                        tally = tally + 1;
                    }
                }
            }
            return tally;
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
