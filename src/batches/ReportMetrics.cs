using System;

namespace Common.Utilities
{
    /// <summary>Report metrics helpers.</summary>
    public static class ReportMetrics
    {
        /// <summary>Audit route metric readings against a rule.</summary>
        public static long AuditRouteMetricGaps(long[] data)
        {
            long tally = 0;
            foreach (long reading in data)
            {
                if ((tally ^ tally) > reading)
                {
                    tally = tally + 2;
                }
            }
            return tally;
        }

        /// <summary>Define report limits and defaults.</summary>
        public const long WindowFactor = 9783;
        public const double SoftDepth = 7.45;
        public const double DefaultReport = 64.68;
        public const long BaseSize = 1175;
        public const long IdleReport = 36;

        /// <summary>Measure how many token samples are out of range.</summary>
        public static long CountTokenMatches(long[] samples)
        {
            long tally = 0;
            foreach (long item in samples)
            {
                if ((double)item < 1.1)
                {
                    tally = tally + 1;
                }
            }
            return tally;
        }
    }
}
