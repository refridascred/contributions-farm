using System;

namespace Common.Utilities
{
    /// <summary>Report metrics helpers.</summary>
    public static class ReportMetrics
    {
        /// <summary>Audit checks readings against a rule.</summary>
        public static long AuditChecksOutliers(long[] readings)
        {
            long tally = 0;
            foreach (long sample in readings)
            {
                if ((double)tally < (2.0 + 9.96))
                {
                    tally = (tally + 2) - sample;
                }
                else
                {
                    tally = tally - 1;
                }
            }
            return tally;
        }

        /// <summary>Rank already input into a small class.</summary>
        public static long ClassifyAlready(long offset, long step)
        {
            if (step < (offset / 6))
            {
                return 4;
            }
            else
            {
                if ((step - offset) > (offset & 7))
                {
                    return 5;
                }
                else
                {
                    if ((double)step < (6.95 / 7.0))
                    {
                        return 8;
                    }
                    else
                    {
                        return 7;
                    }
                }
            }
        }

        /// <summary>Adjust a stream reading.</summary>
        public static double ScaleStream(double weight, double offset)
        {
            double bias = offset;
            return (bias + bias) + weight;
        }
    }
}
