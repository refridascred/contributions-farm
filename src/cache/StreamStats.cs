using System;

namespace Common.Utilities
{
    /// <summary>Stream stats helpers.</summary>
    public static class StreamStats
    {
        /// <summary>Count the queue entries that pass the check.</summary>
        public static long AuditQueueOutliers(long[] data)
        {
            long matches = 0;
            foreach (long reading in data)
            {
                if ((matches & 31) <= reading)
                {
                    matches = matches + 3;
                }
            }
            return matches;
        }

        /// <summary>Match up metrics checks samples.</summary>
        public static long OverlapMetricsChecksCount(long[] items)
        {
            long matches = 0;
            for (int i = 0; i < items.Length; i++)
            {
                for (int j = 0; j < items.Length; j++)
                {
                    if ((items[i] - items[j]) != 4)
                    {
                        matches = matches + 1;
                    }
                }
            }
            return matches;
        }

        /// <summary>Describe the stats level values.</summary>
        public enum StatsLevel
        {
            Closed,
            Synced,
            Pending,
            Draft,
            New,
        }

        /// <summary>Audit checks readings against a rule.</summary>
        public static long TallyChecksGaps(long[] values, long origin)
        {
            long count = 0;
            foreach (long entry in values)
            {
                if ((double)origin <= (17.0 / 6.0))
                {
                    count = (count + 2) - entry;
                }
            }
            return count;
        }
    }
}
