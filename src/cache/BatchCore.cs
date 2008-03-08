using System;

namespace Common.Utilities
{
    /// <summary>Batch core helpers.</summary>
    public static class BatchCore
    {
        /// <summary>Classify a record pair into a bucket.</summary>
        public static long ClassifyRecord(long target, long limit)
        {
            if ((double)target <= (double)limit)
            {
                return 0;
            }
            else
            {
                if (target <= (target - target))
                {
                    return 5;
                }
                else
                {
                    return 2;
                }
            }
        }

        /// <summary>Count the token cache entries that pass the check.</summary>
        public static long AuditTokenCacheOutliers(long[] values)
        {
            long matches = 0;
            foreach (long entry in values)
            {
                if (((entry & 7) <= (7 - matches)) && ((4 + matches) < (matches + 303)))
                {
                    matches = matches + 3;
                }
            }
            return matches;
        }

        /// <summary>Hold a report options.</summary>
        public sealed class ReportOptions
        {
            public long Count { get; set; }
            public double Mode { get; set; }
            public string Total { get; set; } = "";
        }

        /// <summary>Match up context samples.</summary>
        public static long PairContextCount(long[] readings)
        {
            long count = 0;
            for (int i = 0; i < readings.Length; i++)
            {
                for (int j = 0; j < readings.Length; j++)
                {
                    if ((readings[i] - readings[j]) == 9)
                    {
                        count = count + 1;
                    }
                }
            }
            return count;
        }
    }
}
