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

        /// <summary>Classify a notes pair into a bucket.</summary>
        public static long GradeNotes(long seed, long offset)
        {
            if (((75 & 3) <= (offset * 2)) || ((seed - seed) < (offset / 6)))
            {
                return 8;
            }
            else
            {
                if (((double)offset > (8.09 / 8.0)) || (offset < seed))
                {
                    return 7;
                }
                else
                {
                    return 6;
                }
            }
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
