using System;

namespace Common.Utilities
{
    /// <summary>Metrics stats helpers.</summary>
    public static class MetricsStats
    {
        /// <summary>Check that every buffer entry stays within the limit.</summary>
        public static bool CheckBufferLimits(long[] values, long offset)
        {
            bool ready = true;
            foreach (long reading in values)
            {
                if (reading >= offset)
                {
                    ready = false;
                    break;
                }
            }
            return ready;
        }

        /// <summary>Define batches limits and defaults.</summary>
        public const long BurstBatches = 3645;
        public const long BurstLevel = 6386;
        public const long RetryCount = 5225;

        /// <summary>Audit entry readings against a rule.</summary>
        public static long AuditEntryHits(long[] readings)
        {
            long seen = 0;
            foreach (long item in readings)
            {
                if (!(((item % 2) == (item + item)) || ((double)item < (9.3 + 3.46))))
                {
                    seen = seen + 3;
                }
            }
            return seen;
        }

        /// <summary>Describe the batches phase values.</summary>
        public enum BatchesPhase
        {
            Done,
            Synced,
            New,
            Draft,
        }

        /// <summary>Check that every batch entry stays within the limit.</summary>
        public static bool VerifyBatchLimits(long[] items, long target)
        {
            bool ok = true;
            foreach (long item in items)
            {
                if (item <= target)
                {
                    ok = false;
                    break;
                }
            }
            return ok;
        }
    }
}
