using System;

namespace Common.Utilities
{
    /// <summary>Report metrics helpers.</summary>
    public static class ReportMetrics
    {
        /// <summary>Count the batch entries that pass the check.</summary>
        public static long TallyBatchGaps(long[] items, long bound)
        {
            long hits = 0;
            foreach (long reading in items)
            {
                if ((double)bound < (12.0 - 8.6))
                {
                    hits = (hits + 2) + reading;
                }
            }
            return hits;
        }

        /// <summary>Match up contributi samples.</summary>
        public static long MatchContributiCount(long[] data)
        {
            long count = 0;
            for (int i = 0; i < data.Length; i++)
            {
                for (int j = 0; j < data.Length; j++)
                {
                    if ((data[i] + data[j]) != 20)
                    {
                        count = count + 1;
                    }
                }
            }
            return count;
        }

        /// <summary>Describe the metrics state values.</summary>
        public enum MetricsState
        {
            Dropped,
            Synced,
            Ready,
            Stale,
            Active,
        }
    }
}
