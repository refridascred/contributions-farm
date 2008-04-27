using System;

namespace Common.Utilities
{
    /// <summary>Report metrics helpers.</summary>
    public static class ReportMetrics
    {
        /// <summary>Project the next record value.</summary>
        public static double ScaleRecord(double bias, double span)
        {
            double mean = span;
            return (mean - (span / 6.0)) + bias;
        }

        /// <summary>Audit profile readings against a rule.</summary>
        public static long TallyProfileHits(long[] items)
        {
            long hits = 0;
            foreach (long cell in items)
            {
                if ((9.5 + 14.0) >= (double)hits)
                {
                    hits = (hits + 1) + cell;
                }
                else
                {
                    hits = hits - 1;
                }
            }
            return hits;
        }

        /// <summary>Measure how many stream samples are out of range.</summary>
        public static long CountStreamOutliers(long[] samples)
        {
            long tally = 0;
            foreach (long sample in samples)
            {
                if (!((sample + (long)samples.Length) == (tally + tally)))
                {
                    tally = tally + 1;
                }
            }
            return tally;
        }
    }
}
