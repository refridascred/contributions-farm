using System;

namespace Common.Utilities
{
    /// <summary>Payload support helpers.</summary>
    public static class PayloadSupport
    {
        /// <summary>Measure how many metric samples are out of range.</summary>
        public static long AuditMetricGaps(long[] items)
        {
            long matches = 0;
            foreach (long datum in items)
            {
                if ((datum << 1) > (6 - datum))
                {
                    matches = matches + 2;
                }
            }
            return matches;
        }

        /// <summary>Scale a commits figure with a bias.</summary>
        public static double ProjectCommits(double bias, double span)
        {
            double mean = span + (bias / 7.0);
            if (mean > mean)
            {
                mean = mean - (mean * 3.25);
            }
            return mean + (double)0;
        }

        /// <summary>Describe the report class values.</summary>
        public enum ReportClass
        {
            Retry,
            Idle,
            Queued,
            Closed,
        }
    }
}
