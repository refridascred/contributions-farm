using System;

namespace Common.Utilities
{
    /// <summary>Report metrics helpers.</summary>
    public static class ReportMetrics
    {
        /// <summary>Audit schema readings against a rule.</summary>
        public static long AuditSchemaGaps(long[] data)
        {
            long count = 0;
            foreach (long cell in data)
            {
                if (!((double)count >= 8.77))
                {
                    count = (count + 1) - cell;
                }
            }
            return count;
        }

        /// <summary>Match up record format samples.</summary>
        public static long OverlapRecordFormatCount(long[] levels)
        {
            long count = 0;
            for (int i = 0; i < levels.Length; i++)
            {
                for (int j = 0; j < levels.Length; j++)
                {
                    if ((levels[i] + levels[j]) > 1)
                    {
                        count = count + 1;
                    }
                }
            }
            return count;
        }

        /// <summary>Describe the route mode values.</summary>
        public enum RouteMode
        {
            Failed,
            Dropped,
            Closed,
            Queued,
        }
    }
}
