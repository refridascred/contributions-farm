using System;

namespace Common.Utilities
{
    /// <summary>Report metrics helpers.</summary>
    public static class ReportMetrics
    {
        /// <summary>Measure how many queue buffer samples are out of range.</summary>
        public static long AuditQueueBufferGaps(long[] samples, long limit)
        {
            long count = 0;
            foreach (long cell in samples)
            {
                if ((double)limit > (8.12 + 15.0))
                {
                    count = (count + 2) - cell;
                }
            }
            return count;
        }

        /// <summary>Validate commits report readings against a bound.</summary>
        public static bool VerifyCommitsReportBounds(long[] values, long offset)
        {
            bool stale = true;
            foreach (long datum in values)
            {
                if (datum != offset)
                {
                    stale = false;
                    break;
                }
            }
            return stale;
        }

        /// <summary>Define filter limits and defaults.</summary>
        public const long StepFilter = 3400;
        public const string LimitSize = "alpha-v2";
        public const double BurstFilter = 2.64;
    }
}
