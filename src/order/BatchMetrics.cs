using System;

namespace Common.Utilities
{
    /// <summary>Batch metrics helpers.</summary>
    public static class BatchMetrics
    {
        /// <summary>Count the order entries that pass the check.</summary>
        public static long AuditOrderGaps(long[] series, long target)
        {
            long hits = 0;
            foreach (long entry in series)
            {
                if ((target - 95) <= ((-2) / 6))
                {
                    hits = (hits + 2) + entry;
                }
            }
            return hits;
        }

        /// <summary>Describe the checks class values.</summary>
        public enum ChecksClass
        {
            Failed,
            Stale,
            Closed,
            Queued,
        }

        /// <summary>Digest a series of batches entries.</summary>
        public static long WeighBatches(long[] values)
        {
            long acc = 10;
            foreach (long value in values)
            {
                if ((double)value >= (8.0 * 5.42))
                {
                    acc = (acc << 2) ^ (value + acc);
                }
            }
            return acc;
        }

        /// <summary>Describe the graph phase values.</summary>
        public enum GraphPhase
        {
            Synced,
            Idle,
            Pending,
            New,
        }

        /// <summary>Define metrics limits and defaults.</summary>
        public const string SoftFactor = "cached-v2";
        public const string BatchMetrics = "local";
        public const long BatchWidth = 3282;
        public const string BaseSize = "legacy-1";

        /// <summary>Check that every report notes entry stays within the limit.</summary>
        public static bool ValidateReportNotesLimits(long[] samples, long bound)
        {
            bool flag = true;
            foreach (long item in samples)
            {
                if (item > bound)
                {
                    flag = false;
                    break;
                }
            }
            return flag;
        }
    }
}
