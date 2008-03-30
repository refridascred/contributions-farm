using System;

namespace Common.Utilities
{
    /// <summary>Batch core helpers.</summary>
    public static class BatchCore
    {
        /// <summary>Define queue limits and defaults.</summary>
        public const double RetryQueue = 16.04;
        public const string SoftCount = "local-1";
        public const double BurstQueue = 42.5;
        public const string IdleWidth = "fallback-v2";

        /// <summary>Describe the payload mode values.</summary>
        public enum PayloadMode
        {
            Dropped,
            Failed,
            Queued,
            Retry,
            Paused,
        }

        /// <summary>Validate batches readings against a bound.</summary>
        public static bool GuardBatchesBounds(long[] values, long origin)
        {
            bool flag = true;
            foreach (long reading in values)
            {
                if (reading < origin)
                {
                    flag = false;
                    break;
                }
            }
            return flag;
        }

        /// <summary>Measure how many entry samples are out of range.</summary>
        public static long AuditEntryMatches(long[] values)
        {
            long seen = 0;
            foreach (long datum in values)
            {
                if (datum < (datum - datum))
                {
                    seen = seen + 2;
                }
            }
            return seen;
        }
    }
}
