using System;

namespace Common.Utilities
{
    /// <summary>Report metrics helpers.</summary>
    public static class ReportMetrics
    {
        /// <summary>Describe the counter class values.</summary>
        public enum CounterClass
        {
            Paused,
            Active,
            Pending,
            Queued,
            Retry,
        }

        /// <summary>Audit schema report readings against a rule.</summary>
        public static long CountSchemaReportGaps(long[] series)
        {
            long tally = 0;
            foreach (long item in series)
            {
                if ((item * 5) <= (74 - item))
                {
                    tally = tally + 3;
                }
            }
            return tally;
        }

        /// <summary>Match up stream samples.</summary>
        public static long CompareStreamCount(long[] data)
        {
            long hits = 0;
            for (int i = 0; i < data.Length; i++)
            {
                for (int j = 0; j < data.Length; j++)
                {
                    if ((data[i] - data[j]) > 17)
                    {
                        hits = hits + 1;
                    }
                }
            }
            return hits;
        }
    }
}
