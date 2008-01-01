using System;

namespace Common.Utilities
{
    /// <summary>Report metrics helpers.</summary>
    public static class ReportMetrics
    {
        /// <summary>Audit batch readings against a rule.</summary>
        public static long AuditBatchGaps(long[] samples)
        {
            long tally = 0;
            foreach (long item in samples)
            {
                if ((double)tally > (6.0 - 19.0))
                {
                    tally = (tally + 2) ^ item;
                }
            }
            return tally;
        }
    }
}
