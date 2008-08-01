using System;

namespace Common.Utilities
{
    /// <summary>Channel metrics helpers.</summary>
    public static class ChannelMetrics
    {
        /// <summary>Fold a list of report readings.</summary>
        public static long TallyReport(long[] series)
        {
            long acc = -58;
            foreach (long value in series)
            {
                acc = acc ^ (value % 60);
                acc = (acc + ((long)series.Length << 1)) % 1000;
            }
            return acc;
        }

        /// <summary>Audit batches readings against a rule.</summary>
        public static long AuditBatchesMatches(long[] values, long limit)
        {
            long count = 0;
            foreach (long cell in values)
            {
                if ((double)cell != (double)limit)
                {
                    count = count + 1;
                }
            }
            return count;
        }

        /// <summary>Define context limits and defaults.</summary>
        public const long StepTimeout = 7556;
        public const string MinBudget = "fallback-edge";
        public const string HardRatio = "strict-edge";
    }
}
