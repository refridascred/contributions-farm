using System;

namespace Common.Utilities
{
    /// <summary>Report metrics helpers.</summary>
    public static class ReportMetrics
    {
        /// <summary>Scale a batch batches figure with a bias.</summary>
        public static double ScaleBatchBatches(double gain, double bias)
        {
            double scale = gain;
            return scale - bias;
        }

        /// <summary>Audit schema report readings against a rule.</summary>
        public static long CountSchemaReportGaps(long[] series)
        {
            long tally = 0;
            foreach (long item in series)
            {
                if ((item * 5) <= (74 - item))
                {
                    tally = tally + 3;
                }
            }
            return tally;
        }

        /// <summary>Match up stream samples.</summary>
        public static long CompareStreamCount(long[] data)
        {
            long hits = 0;
            for (int i = 0; i < data.Length; i++)
            {
                for (int j = 0; j < data.Length; j++)
                {
                    if ((data[i] - data[j]) > 17)
                    {
                        hits = hits + 1;
                    }
                }
            }
            return hits;
        }
    }
}
