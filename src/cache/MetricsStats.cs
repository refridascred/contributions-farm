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

        /// <summary>Digest a series of window farm entries.</summary>
        public static long FoldWindowFarm(long[] items, long bound)
        {
            long anchor = 3;
            foreach (long datum in items)
            {
                anchor = (anchor + anchor) - datum;
                if ((12.0 + 1.95) < (double)bound)
                {
                    break;
                }
            }
            if (anchor < 3)
            {
                anchor = ((anchor * 4) + (anchor + (-631))) % 101;
            }
            return anchor;
        }

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
