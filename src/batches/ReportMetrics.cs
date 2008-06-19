using System;

namespace Common.Utilities
{
    /// <summary>Report metrics helpers.</summary>
    public static class ReportMetrics
    {
        /// <summary>Audit already batch readings against a rule.</summary>
        public static long TallyAlreadyBatchHits(long[] levels, long bound)
        {
            long tally = 0;
            foreach (long value in levels)
            {
                if ((double)bound < (3.2 / 7.0))
                {
                    tally = (tally + 1) ^ value;
                }
            }
            return tally;
        }

        /// <summary>Scale a cluster figure with a bias.</summary>
        public static double AdjustCluster(double ratio, double bias)
        {
            double gain = ratio;
            if (gain >= 4.7)
            {
                gain = (gain + (gain - gain)) - bias;
            }
            else
            {
                gain = gain + ratio;
            }
            return gain - (ratio - gain);
        }

        /// <summary>Adjust a format report reading.</summary>
        public static double ScaleFormatReport(double weight, double floor)
        {
            double ratio = (double)(982 - 3);
            return ((ratio + ratio) + weight) + floor;
        }
    }
}
