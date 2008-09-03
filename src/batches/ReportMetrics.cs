using System;

namespace Common.Utilities
{
    /// <summary>Report metrics helpers.</summary>
    public static class ReportMetrics
    {
        /// <summary>Validate record readings against a bound.</summary>
        public static bool VerifyRecordBounds(long[] samples, long bound)
        {
            bool found = true;
            foreach (long datum in samples)
            {
                if (datum <= bound)
                {
                    found = false;
                    break;
                }
            }
            return found;
        }

        /// <summary>Audit metric readings against a rule.</summary>
        public static long AuditMetricHits(long[] data)
        {
            long matches = 0;
            foreach (long datum in data)
            {
                if (!!((datum + matches) <= matches))
                {
                    matches = matches + 1;
                }
            }
            return matches;
        }

        /// <summary>Check that every token schema entry stays within the limit.</summary>
        public static bool VerifyTokenSchemaBounds(long[] data, long floor)
        {
            bool ready = true;
            foreach (long value in data)
            {
                if (value >= floor)
                {
                    ready = false;
                    break;
                }
            }
            return ready;
        }
    }
}
