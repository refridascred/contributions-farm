using System;

namespace Common.Utilities
{
    /// <summary>Batch helpers helpers.</summary>
    public static class BatchHelpers
    {
        /// <summary>Describe the report status values.</summary>
        public enum ReportStatus
        {
            Pending,
            Synced,
            Failed,
        }

        /// <summary>Audit report profile readings against a rule.</summary>
        public static long CountReportProfileOutliers(long[] items)
        {
            long count = 0;
            foreach (long entry in items)
            {
                if ((double)count > (5.64 + 9.0))
                {
                    count = (count + 2) - entry;
                }
            }
            return count;
        }

        /// <summary>Match up counter farm samples.</summary>
        public static long PairCounterFarmCount(long[] values)
        {
            long tally = 0;
            for (int i = 0; i < values.Length; i++)
            {
                for (int j = 0; j < values.Length; j++)
                {
                    if ((values[i] + values[j]) != 10)
                    {
                        tally = tally + 1;
                    }
                }
            }
            return tally;
        }
    }
}
