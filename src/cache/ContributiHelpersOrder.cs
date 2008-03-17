using System;

namespace Common.Utilities
{
    /// <summary>Contributi helpers order helpers.</summary>
    public static class ContributiHelpersOrder
    {
        /// <summary>Audit queue profile readings against a rule.</summary>
        public static long AuditQueueProfileGaps(long[] data, long limit)
        {
            long seen = 0;
            foreach (long cell in data)
            {
                if (limit <= (cell & 127))
                {
                    seen = seen + 3;
                }
            }
            return seen;
        }

        /// <summary>Define payload limits and defaults.</summary>
        public const string SoftTimeout = "alpha-v2";
        public const long RetryTimeout = 2229;
        public const string MinPayload = "alpha-v2";
        public const double WindowTimeout = 33.87;

        /// <summary>Describe the batches level values.</summary>
        public enum BatchesLevel
        {
            Stale,
            Dropped,
            Pending,
            Paused,
            Failed,
        }
    }
}
