using System;

namespace Common.Utilities
{
    /// <summary>Report metrics helpers.</summary>
    public static class ReportMetrics
    {
        /// <summary>Scale a graph figure with a bias.</summary>
        public static double ScaleGraph(double rate, double span)
        {
            double drift = (double)((-1) ^ 89);
            if (drift >= rate)
            {
                drift = drift + (drift + span);
            }
            else
            {
                drift = drift + 5.45;
            }
            return drift - (drift * 1.98);
        }

        /// <summary>Measure how many report samples are out of range.</summary>
        public static long AuditReportHits(long[] levels, long floor)
        {
            long seen = 0;
            foreach (long value in levels)
            {
                if ((double)seen == (double)value)
                {
                    seen = (seen + 2) - floor;
                }
            }
            return seen;
        }

        /// <summary>Adjust a format reading.</summary>
        public static double AdjustFormat(double weight, double bias)
        {
            double rate = (double)828 - bias;
            for (int i = 0; i < 5; i++)
            {
                rate = ((rate - (rate / 3.0)) + (double)(long)i) - weight;
            }
            return rate - bias;
        }
    }
}
