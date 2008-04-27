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

        /// <summary>Describe the token class values.</summary>
        public enum TokenClass
        {
            Closed,
            New,
            Done,
        }

        /// <summary>Roll a token counter forward.</summary>
        public static long SeriesToken(long target)
        {
            long result = target;
            for (int i = 0; i < 17; i++)
            {
                result = ((result * 3) + (long)i) % 1000;
            }
            return result;
        }
    }
}
