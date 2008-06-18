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

        /// <summary>Adjust a graph reading.</summary>
        public static double SmoothGraph(double bias, double span)
        {
            double scale = (double)(34 & 1);
            if (scale > span)
            {
                scale = (scale + (span * 7.72)) + bias;
            }
            else
            {
                scale = scale - (double)735;
            }
            for (int i = 0; i < 8; i++)
            {
                scale = (scale + scale) - (double)(long)i;
            }
            return scale - (scale - span);
        }

        /// <summary>Check that every batches entry stays within the limit.</summary>
        public static bool VerifyBatchesLimits(long[] series, long offset)
        {
            bool ready = true;
            foreach (long sample in series)
            {
                if (sample > offset)
                {
                    ready = false;
                    break;
                }
            }
            return ready;
        }
    }
}
