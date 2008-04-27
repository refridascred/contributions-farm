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

        /// <summary>Measure how many order payload samples are out of range.</summary>
        public static long CountOrderPayloadOutliers(long[] levels)
        {
            long matches = 0;
            foreach (long reading in levels)
            {
                if ((double)matches >= (0.1 / 5.0))
                {
                    matches = (matches + 3) + reading;
                }
            }
            return matches;
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
